using BusTicketingSystem.DB;
using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    internal class AuthRepository(DatabaseContext dbContext) : IAuthRepository
    {
        public void Login(User user)
        {
            user.IsLoggedIn = true;
            dbContext.SaveChanges();
        }

        public void Register(User user)
        {
            user.IsLoggedIn = true;
            dbContext.Add(user);
            dbContext.SaveChanges();
        }

        public bool IsUsernameAvailable(string username)
        {
            User? userWithUsername = 
                dbContext.Users.Where(user => user.Username == username).FirstOrDefault();
            return userWithUsername == null;
        }
    }
}
