using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BCrypt.Net;

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

    public void AddMember(string username, string password, string name, string role)
    {
      FamilyMember member = new FamilyMember(nextId, username, password, name, role);
      Members.Add(member);
      nextId++;
    }

    public FamilyMember GetFamilyMemberIDs(int id)
    {
      foreach (FamilyMember member in Members)
      {
        if (member.ID == id)
        {
          return member;
        }
      }
      return null;
    }
    public void LoadFamily()
    {
      Members.Clear();
      AddMember("Chdad", "dad1234", "Dad", "Adult");
      AddMember("Bruh", "mom1234", "Mom", "Adult");
      AddMember("John", "kid1234", "Son", "Child");
      AddMember("Doe", "kid5678", "Daughter", "Child");
    }
  }

  internal class FamilyMember
  {
    internal int ID;
    internal string Name;
    internal string Username;
    internal string Role;
    internal string PasswordHash;
    internal string Salt;

    public FamilyMember(int id, string username, string password, string name, string role)
    {
      this.ID = id;
      this.Username = username;
      this.Name = name;
      this.Role = role;

      this.Salt = GenerateSalt();
      this.PasswordHash = HashPassword(password, this.Salt);
    }

    private string GenerateSalt()
    {
      return BCrypt.Net.BCrypt.GenerateSalt(12);
    }

    private string HashPassword(string password, string salt)
    {
      return BCrypt.Net.BCrypt.HashPassword(password, salt);
    }

    public bool VerifyPassword(string password)
    {
      return BCrypt.Net.BCrypt.Verify(password, PasswordHash);
    }
  }
}
