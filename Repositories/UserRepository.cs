using BusTicketingSystem.DB;
using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public class UserRepository(DatabaseContext dbContext) : IUserRepository
    {

        public User? GetUserByUsername(string username)
        {
            return dbContext.Users.Where(user => user.Username == username).FirstOrDefault();
        }

        public User? GetCurrentUser()
        {
            return dbContext.Users.Where(user => user.IsLoggedIn).FirstOrDefault();
        }

        public void Logout()
        {
            User? loggedUser = dbContext.Users.Where(user => user.IsLoggedIn).FirstOrDefault();
            if (loggedUser != null)
            {
                loggedUser.IsLoggedIn = false;
                dbContext.SaveChanges();
            }
        }
    }
}
