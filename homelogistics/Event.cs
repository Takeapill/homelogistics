using System;
using System.Collections.Generic;
using System.Linq;

namespace homelogistics
{
  internal class Event
  {
    internal int ID { get; set; }
    internal string Title { get; set; }
    internal string Description { get; set; }
    internal DateTime Date { get; set; }
    internal string Status { get; set; }
    internal List<int> participants = new List<int>();

    internal Event(string title, string description, DateTime date, string status, List<int> participants)
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
    internal Task(string title, string description, DateTime date, string status, List<int> participants)
      : base(title, description, date, status, participants)
    {
      ID = nextId;
      nextId++;
    }
  }
  internal class Meal : Event
  {
    private static int nextId = 0;
    internal Meal(string title, string description, DateTime date, string status, List<int> participants)
      : base(title, description, date, status, participants)
    {
      ID = nextId;
      nextId++;
    }
  }
  internal class ShopItem : Event
  {
    private static int nextId = 0;
    private int Quantity { get; set; }
    private string Unit { get; set; }
    internal ShopItem(string title, string description, DateTime date, int quantity, string unit, List<int> participants)
      : base(title, description, date, "Pending", participants)
    {
      ID = nextId;
      nextId++;
      Quantity = quantity;
      Unit = unit;
    }

    internal string GetUnitQty()
    {
      return Quantity + Unit;
    } 
  }
  internal class EventFactory
  {
    static List<int> p = new List<int> { 1, 2, 3, 4 };
    internal static Event CreateEvent(string type, string title, string description, DateTime date, List<int> participants, string status = "Pending", int quantity = 0, string unit = " ")
    {
      switch (type)
      {
        case "Task":
          return new Task(title, description, date, status, participants);
        case "Meal":
          return new Meal(title, description, date, status, participants);
        case "ShopItem":
          return new ShopItem(title, description, date, quantity, unit, participants);
        default:
          return new Event(title, description, date, status, participants);
      }
    }
  }
  internal class EventList
  {
    private List<int> p = new List<int> { 1, 2, 3, 4 };
    private static EventList instance;
    internal List<Event> Events { get; } = new List<Event>();
    internal List<Task> Tasks { get; } = new List<Task>();
    internal List<Meal> Meals { get; } = new List<Meal>();
    internal List<ShopItem> ShopItems { get; } = new List<ShopItem>();

    private EventList()
    {
      LoadTasks();
    }

    internal static EventList GetInstance()
    {
      if (instance == null)
      {
        instance = new EventList();
      }
      return instance;
    }

    private void LoadTasks()
    {
      Events.Clear();

      Events.Add(EventFactory.CreateEvent("Task", "Wash the car", "Washing the car is not fun", DateTime.Now.AddDays(1), p));
      Events.Add(EventFactory.CreateEvent("Task", "Buy groceries", "Go check the incredible shopping list in the app", DateTime.Now.AddDays(2), p));
      Events.Add(EventFactory.CreateEvent("Task", "Pay the bills", "You don't have any more money hihi", DateTime.Now.AddDays(3), p));
      Events.Add(EventFactory.CreateEvent("Task", "Call the plumber", "Don't **** the plumber", DateTime.Now.AddDays(4), p));

      Events.Add(EventFactory.CreateEvent("Meal", "Lunch", "Kinders", DateTime.Now.AddDays(1), p));
      Events.Add(EventFactory.CreateEvent("Meal", "Dinner", "Kinders", DateTime.Now.AddDays(1), p));
      Events.Add(EventFactory.CreateEvent("Meal", "Lunch", "Kinders", DateTime.Now.AddDays(2), p));
      Events.Add(EventFactory.CreateEvent("Meal", "Dinner", "Kinders", DateTime.Now.AddDays(2), p));

      Events.Add(EventFactory.CreateEvent("ShopItem", "Milk", "Lorem Ipsum", DateTime.Now.AddDays(1), p, "", 2, "L"));
      Events.Add(EventFactory.CreateEvent("ShopItem", "Bread", "Lorem Ipsum", DateTime.Now.AddDays(1), p, "", 1, "U"));
      Events.Add(EventFactory.CreateEvent("ShopItem", "Eggs", "Lorem Ipsum", DateTime.Now.AddDays(2), p, "", 6, "U"));
      Events.Add(EventFactory.CreateEvent("ShopItem", "Butter", "Lorem Ipsum", DateTime.Now.AddDays(3), p, "", 1, "U"));

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
    internal List<ShopItem> GetNextShoppingList()
    {
      DateTime nextDate = DateTime.MaxValue;
      foreach (ShopItem shopItem in ShopItems)
      {
        if (shopItem.Status == "Done") continue;
        if (shopItem.Date.Date >= DateTime.Today && shopItem.Date.Date < nextDate)
        {
          nextDate = shopItem.Date.Date;
        }
      }

      return ShopItems.Where(s => s.Date.Date == nextDate).ToList();
    }

    internal List<Event> GetUserEvents(int id)
    {
      foreach (Event ev in Events)
      {
        if (ev.participants.Contains(id))
        {
          return Events.Where(e => e.participants.Contains(id)).ToList();
        }
      } 
      return null;
    }
  }
}
