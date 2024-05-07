using BusTicketingSystem.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class User
    {

        public User()
        {
        }

        public User(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            Username = username;
            PasswordHash = PasswordHashingManager.HashPasword(password);
        }


        public int Id { get; set; }

        public string Username { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public bool IsAdmin { get; set; }

        public bool IsLoggedIn { get; set; }
    }
}
