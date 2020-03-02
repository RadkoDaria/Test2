using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
    }
    public static class UserRepo
    {
        private static List<User> _users;
        public static List<User> GetUsers()
        {
            if (_users == null)
            {
                _users = new List<User>
                {
                    new User { Id = 1, Name = "John", Email = "email1" },
                    new User { Id = 2, Name = "Jack", Email = "email2" },
                    new User { Id = 3, Name = "James", Email = "email3" }
                };
            }
            return _users;
        }
        public static void AddUser(User user)
        {
            _users?.Add(user);
        }
    }
}