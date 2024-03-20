using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homelogistics
{
  internal class Family
  {
    private static Family instance;
    private List<FamilyMember> members = new List<FamilyMember>();
    private List<Event> events = EventList.GetInstance().Events;
    int nextId = 1;
    private Family() {}

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

    public FamilyMember GetFamilyMembers(int id)
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
  }

  internal class FamilyMember
  {
    internal int id;
    private string name;
    private string role;
    private Family family = Family.GetInstance();
    private List<Event> events;
    public FamilyMember(int id, string name, string role)
    {
      this.id = id;
      this.name = name;
      this.role = role;
      EventList.GetInstance().GetUserEvents(id);
    }
  }
}
