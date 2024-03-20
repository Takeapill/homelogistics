using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace homelogistics
{
  internal class Family
  {
    private static Family instance;
    public List<FamilyMember> members;
    private List<Event> events = EventList.GetInstance().Events;
    int nextId = 1;
    private Family() 
    {
      members = new List<FamilyMember>();
      LoadFamily();
    }

    public static Family GetInstance()
    {
      if (instance == null)
      {
        instance = new Family();
      }
      return instance;
    }

    public void AddMember(string name, string role)
    {
      FamilyMember member = new FamilyMember(nextId, name, role);
      members.Add(member);
      nextId++;
    }

    public FamilyMember GetFamilyMemberIDs(int id)
    {
      foreach (FamilyMember member in members)
      {
        if (member.id == id)
        {
          return member;
        }
      }
      return null;
    }
    public void LoadFamily()
    {
      members.Clear();
      AddMember("Dad", "Adult");
      AddMember("Mom", "Adult");
      AddMember("Son", "Child");
      AddMember("Daughter", "Child");
    }
  }

  internal class FamilyMember
  {
    internal int id;
    internal string name;
    internal string role;
    internal List<Event> events;
    public FamilyMember(int id, string name, string role)
    {
      this.id = id;
      this.name = name;
      this.role = role;
      this.events = EventList.GetInstance().GetUserEvents(id);
    }
  }
}
