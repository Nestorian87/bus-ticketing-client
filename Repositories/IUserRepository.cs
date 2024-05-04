using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public interface IUserRepository
    {

        User? GetUserByUsername(string username);

        User? GetCurrentUser();

        void Logout();
    }
}
