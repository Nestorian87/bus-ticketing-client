using BusTicketingSystem.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    [Table("users")]
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


        [Column("user_id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; } = null!;

        [Column("password")]
        public string PasswordHash { get; set; } = null!;


        [Column("name")]
        public string Name { get; set; } = null!;

        [Column("surname")]
        public string Surname { get; set; } = null!;

        [Column("admin")]
        public bool IsAdmin { get; set; }

        [Column("logged_in")]
        public bool IsLoggedIn { get; set; }
    }
}
