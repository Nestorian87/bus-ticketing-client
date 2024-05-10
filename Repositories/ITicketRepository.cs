using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public interface ITicketRepository
    {
        void BuyTicket(int tripId, int startStopId, int endStopId, DateTime date);

        List<Ticket> GetActiveTickets();

    }
}
