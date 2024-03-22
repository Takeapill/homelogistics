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
    internal List<FamilyMember> Members { get; private set; }
    internal FamilyMember CurrentUser { get; set; }
    int nextId = 1;
    private Family() 
    {
      Members = new List<FamilyMember>();
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
      Members.Add(member);
      nextId++;
    }

    public FamilyMember GetFamilyMemberIDs(int id)
    {
      foreach (FamilyMember member in Members)
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
      Members.Clear();
      AddMember("Dad", "Adult");
      AddMember("Mom", "Adult");
      AddMember("Son", "Child");
      AddMember("Daughter", "Child");
      CurrentUser = Members[1];
    }
  }

  internal class FamilyMember
  {
    internal int id;
    internal string name;
    internal string role;
    public FamilyMember(int id, string name, string role)
    {
      this.id = id;
      this.name = name;
      this.role = role;
    }
  }
}
