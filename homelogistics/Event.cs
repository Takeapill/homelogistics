using System;
using System.Collections.Generic;
using System.Linq;

namespace homelogistics
{
  internal class Event
  {
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
    private List<int> participants = new List<int>();

    public Event(string title, string description, DateTime date, string status, List<int> participants)
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
    public Task(string title, string description, DateTime date, string status, List<int> participants)
      : base(title, description, date, status, participants)
    {
      ID = nextId;
      nextId++;
    }
  }
  internal class Meal : Event
  {
    private static int nextId = 0;
    public Meal(string title, string description, DateTime date, string status, List<int> participants)
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
    public ShopItem(string title, string description, DateTime date, int quantity, string unit, List<int> participants)
      : base(title, description, date, "Pending", participants)
    {
      ID = nextId;
      nextId++;
      Quantity = quantity;
      Unit = unit;
    }

    public string GetUnitQty()
    {
      return Quantity + Unit;
    } 
  }
  internal class EventFactory
  {
    public static Event CreateEvent(string type, string title, string description, DateTime date, string status = "Pending", List<int> participants = null, int quantity = 0, string unit = " ")
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
    private static EventList instance;
    public List<Event> Events { get; } = new List<Event>();
    public List<Task> Tasks { get; } = new List<Task>();
    public List<Meal> Meals { get; } = new List<Meal>();
    public List<ShopItem> ShopItems { get; } = new List<ShopItem>();

    private EventList()
    {
      LoadTasks();
    }

    public static EventList GetInstance()
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

      Events.Add(EventFactory.CreateEvent("Task", "Wash the car", "Washing the car is not fun", DateTime.Now.AddDays(1)));
      Events.Add(EventFactory.CreateEvent("Task", "Buy groceries", "Go check the incredible shopping list in the app", DateTime.Now.AddDays(2)));
      Events.Add(EventFactory.CreateEvent("Task", "Pay the bills", "You don't have any more money hihi", DateTime.Now.AddDays(3)));
      Events.Add(EventFactory.CreateEvent("Task", "Call the plumber", "Don't **** the plumber", DateTime.Now.AddDays(4)));

      Events.Add(EventFactory.CreateEvent("Meal", "Lunch", "Kinders", DateTime.Now.AddDays(1)));
      Events.Add(EventFactory.CreateEvent("Meal", "Dinner", "Kinders", DateTime.Now.AddDays(1)));
      Events.Add(EventFactory.CreateEvent("Meal", "Lunch", "Kinders", DateTime.Now.AddDays(2)));
      Events.Add(EventFactory.CreateEvent("Meal", "Dinner", "Kinders", DateTime.Now.AddDays(2)));

      Events.Add(EventFactory.CreateEvent("ShopItem", "Milk", "Lorem Ipsum", DateTime.Now.AddDays(1), "", null, 2, "L"));
      Events.Add(EventFactory.CreateEvent("ShopItem", "Bread", "Lorem Ipsum", DateTime.Now.AddDays(1), "", null, 1, "U"));
      Events.Add(EventFactory.CreateEvent("ShopItem", "Eggs", "Lorem Ipsum", DateTime.Now.AddDays(2), "", null, 6, "U"));
      Events.Add(EventFactory.CreateEvent("ShopItem", "Butter", "Lorem Ipsum", DateTime.Now.AddDays(3), "", null, 1, "U"));

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
    public List<ShopItem> GetNextShoppingList()
    {
      DateTime nextDate = DateTime.MaxValue;
      foreach (ShopItem shopItem in ShopItems)
      {
        if (shopItem.Date.Date >= DateTime.Today && shopItem.Date.Date < nextDate)
        {
          nextDate = shopItem.Date.Date;
        }
      }

      return ShopItems.Where(s => s.Date.Date == nextDate).ToList();
    }

    public List<Event> GetUserEvents(int id)
    {
      return null;
    }
  }
}
