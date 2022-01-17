using System;
using System.Collections.Generic;
using System.Text;

namespace UserNamespace
{
    class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string id, string name, string surname, int age, string email, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = password;
        }
    }
}
