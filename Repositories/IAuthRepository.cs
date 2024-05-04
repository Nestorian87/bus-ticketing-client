using BusTicketingSystem.Models;

namespace BusTicketingSystem.Repositories
{
    public interface IAuthRepository
    {
        void Login(User user);

        void Register(User user);

        bool IsUsernameAvailable(string username);
    }
}
