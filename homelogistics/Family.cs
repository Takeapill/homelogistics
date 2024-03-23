using System;
using System.Collections.Generic;
using System.Security.Cryptography;

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
      byte[] saltBytes = new byte[16]; // Adjust size as per your requirements
      using (var rng = new RNGCryptoServiceProvider())
      {
        rng.GetBytes(saltBytes);
      }
      return Convert.ToBase64String(saltBytes);
    }

    private string HashPassword(string password, string salt)
    {
      byte[] saltBytes = Convert.FromBase64String(salt);

      using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000)) // Adjust iteration count as per your requirements
      {
        byte[] hashBytes = pbkdf2.GetBytes(20); // 20 bytes for SHA-1
        return Convert.ToBase64String(hashBytes);
      }
    }

    public bool VerifyPassword(string password)
    {
      string hashedPassword = HashPassword(password, this.Salt);
      return hashedPassword == this.PasswordHash;
    }
  }
}
