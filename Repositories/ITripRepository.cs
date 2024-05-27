using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public interface ITripRepository
    {

        List<Trip> Find(Stop fromStop, Stop toStop, DateTime date);
        List<Trip> GetByRouteId(int routeId);
        bool IsTripWithActiveTickets(int tripId);
        void AddTrip(Trip trip);
        void DeleteTrip(int tripId);
        void UpdateTrip(Trip trip);

    }
}
