using System;

namespace Logic
{
    public class User
    {
        public int Id { get; }
        public string Name { get; }
        public string SurName { get; }
        public string Username { get; }
        public string Password { get; }



        public User(int id, string name, string surName, string username, string password)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Username = username;
            Password = password;
        }



    }
}
