using System;
using System.Collections.Generic;
using System.Linq;

namespace homelogistics
{
  enum EventType
  {
    Task,
    Meal,
    ShopItem
  }
  enum EventStatus
  {
    Pending,
    Done
  }
  internal class Event
  {
    internal int ID { get; set; }
    internal string Title { get; set; }
    internal string Description { get; set; }
    internal DateTime Date { get; set; }
    internal EventStatus Status { get; set; }
    internal List<FamilyMember> participants = new List<FamilyMember>();

    internal Event(string title, string description, DateTime date, EventStatus status, List<FamilyMember> participants)
    {
      Title = title;
      Description = description;
      Date = date;
      Status = status;
      this.participants = participants;
    }
  }
  internal class Task : Event
  {
    private static int nextId = 0;
    internal Task(string title, string description, DateTime date, EventStatus status, List<FamilyMember> participants)
      : base(title, description, date, status, participants)
    {
      ID = nextId;
      nextId++;
    }
  }
  internal class Meal : Event
  {
    private static int nextId = 0;
    internal Meal(string title, string description, DateTime date, EventStatus status, List<FamilyMember> participants)
      : base(title, description, date, status, participants)
    {
      ID = nextId;
      nextId++;
    }
  }
  internal class ShopItem : Event
  {
    private static int nextId = 0;
    internal int Quantity { get; set; }
    internal string Unit { get; set; }
    internal ShopItem(string title, string description, DateTime date, int quantity, string unit, List<FamilyMember> participants)
      : base(title, description, date, EventStatus.Pending, participants)
    {
      ID = nextId;
      nextId++;
      Quantity = quantity;
      Unit = unit;
    }

    internal string[] UnitQty
    {
      get
      {
        string[] result = new string[2];
        result[0] = Quantity.ToString();
        result[1] = Unit;
        return result;
      }
    }
  }
  internal class EventFactory
  {
    static List<int> p = new List<int> { 1, 2, 3, 4 };
    internal static Event CreateEvent(EventType type, string title, string description, DateTime date, List<FamilyMember> participants, EventStatus status = EventStatus.Pending, int quantity = 0, string unit = "")
    {
      switch (type)
      {
        case EventType.Task:
          return new Task(title, description, date, status, participants);
        case EventType.Meal:
          return new Meal(title, description, date, status, participants);
        case EventType.ShopItem:
          return new ShopItem(title, description, date, quantity, unit, participants);
        default:
          return new Event(title, description, date, status, participants);
      }
    }
    internal static Event CreateAndAddEvent(EventType type, string title, string description, DateTime date, List<FamilyMember> participants, EventStatus status = EventStatus.Pending, int quantity = 0, string unit = " ")
    {
      Event e = CreateEvent(type, title, description, date, participants, status, quantity, unit);
      EventList.GetInstance().Events.Add(e);
      return e;
    }
  }
  internal class EventList
  {
    private static EventList instance;
    internal List<Event> Events { get; } = new List<Event>();
    internal List<Task> Tasks { get; } = new List<Task>();
    internal List<Meal> Meals { get; } = new List<Meal>();
    internal List<ShopItem> ShopItems { get; } = new List<ShopItem>();

    private EventList()
    {
    }

    internal static EventList GetInstance()
    {
      if (instance == null)
      {
        instance = new EventList();
      }
      return instance;
    }

    internal void LoadEvents()
    {

      List<FamilyMember> p = new List<FamilyMember>(Family.GetInstance().Members);
      p.Remove(Family.GetInstance().CurrentUser);

      EventFactory.CreateAndAddEvent(EventType.Task, "Wash the car", "Washing the car is not fun", DateTime.Now.AddDays(1), p);
      EventFactory.CreateAndAddEvent(EventType.Task, "Buy groceries", "Go check the incredible shopping list in the app", DateTime.Now.AddDays(2), p);
      EventFactory.CreateAndAddEvent(EventType.Task, "Pay the bills", "You don't have any more money hihi", DateTime.Now.AddDays(3), p);
      EventFactory.CreateAndAddEvent(EventType.Task, "Call the plumber", "Don't **** the plumber", DateTime.Now.AddDays(4), p);

      EventFactory.CreateAndAddEvent(EventType.Meal, "Lunch", "Kinders", DateTime.Now.AddDays(1), p);
      EventFactory.CreateAndAddEvent(EventType.Meal, "Dinner", "Kinders", DateTime.Now.AddDays(1), p);
      EventFactory.CreateAndAddEvent(EventType.Meal, "Lunch", "Kinders", DateTime.Now.AddDays(10), p);
      EventFactory.CreateAndAddEvent(EventType.Meal, "Dinner", "Kinders", DateTime.Now.AddDays(20), p);

      EventFactory.CreateAndAddEvent(EventType.ShopItem, "Milk", "Lorem Ipsum", DateTime.Now.AddDays(1), p, EventStatus.Pending, 2, "L");
      EventFactory.CreateAndAddEvent(EventType.ShopItem, "Bread", "Lorem Ipsum", DateTime.Now.AddDays(1), p, EventStatus.Pending, 1, "U");
      EventFactory.CreateAndAddEvent(EventType.ShopItem, "Eggs", "Lorem Ipsum", DateTime.Now.AddDays(2), p, EventStatus.Pending, 6, "U");
      EventFactory.CreateAndAddEvent(EventType.ShopItem, "Butter", "Lorem Ipsum", DateTime.Now.AddDays(3), p, EventStatus.Pending, 1, "U");
      foreach (Event e in Events)
      {
        switch (e)
        {
          case Task t:
            Tasks.Add(t);
            break;
          case Meal m:
            Meals.Add(m);
            break;
          case ShopItem s:
            ShopItems.Add(s);
            break;
        }
      }
    }
    internal void AddEvent(Event e)
    {
      Events.Add(e);
      switch (e)
      {
        case Task t:
          Tasks.Add(t);
          break;
        case Meal m:
          Meals.Add(m);
          break;
        case ShopItem s:
          ShopItems.Add(s);
          break;
      }
    } 
    internal List<ShopItem> GetNextShoppingList()
    {
      DateTime nextDate = DateTime.MaxValue;
      foreach (ShopItem shopItem in ShopItems)
      {
        if (shopItem.Status == EventStatus.Done) continue;
        if (shopItem.Date.Date >= DateTime.Today && shopItem.Date.Date < nextDate)
        {
          nextDate = shopItem.Date.Date;
        }
      }

      return ShopItems.Where(s => s.Date.Date == nextDate).ToList();
    }

    internal List<Meal> GetWeekMeals()
    {
      return Meals.Where(m => m.Date >= DateTime.Now && m.Date <= DateTime.Now.AddDays(7)).ToList();
    }

    internal List<Event> GetUserEvents(int id)
    {
      foreach (Event ev in Events)
      {
        foreach (FamilyMember member in Family.GetInstance().Members)
        {
          if (member.id == id)
          {
            return Events.Where(e => e.participants.Contains(member)).ToList();
          }
        }
      }
      return null;
    }

    internal List<Event> GetEventsByDate(DateTime date)
    {
      return Events.Where(e => e.Date.Date == date.Date).ToList();
    } 
    internal List<Event> GetEventsByStatus(EventStatus status)
    {
      return Events.Where(e => e.Status == status).ToList();
    }
    internal List<Event> GetCurrentUserEvents()
    {
      return GetUserEvents(Family.GetInstance().CurrentUser.id);
    }
    internal List<Event> GetCurrentUserEventsByDate(DateTime date)
    {
      return GetEventsByDate(date).Where(e => e.participants.Contains(Family.GetInstance().CurrentUser)).ToList();
    }
    internal List<Event> GetCurrentUserEventsByStatus(EventStatus status)
    {
      return GetEventsByStatus(status).Where(e => e.participants.Contains(Family.GetInstance().CurrentUser)).ToList();
    }
    internal List<Event> GetEventsByType(EventType type)
    {
      switch (type)
      {
        case EventType.Task:
          return Events.Where(e => e is Task).ToList();
        case EventType.Meal:
          return Events.Where(e => e is Meal).ToList();
        case EventType.ShopItem:
          return Events.Where(e => e is ShopItem).ToList();
        default:
          return Events;
      }
    }
    internal List<Event> GetCurrentUserEventsByType(EventType type)
    {
      return GetEventsByType(type).Where(e => e.participants.Contains(Family.GetInstance().CurrentUser)).ToList();
    }
  }
}
