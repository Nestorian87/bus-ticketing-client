using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public interface IStopsRepository
    {
        List<Stop> GetAllStops();
        void AddStop(Stop stop);
        void DeleteStop(int stopId);
        void UpdateStop(Stop stop);
        bool IsStopUsedOnRoutes(int stopId);
    }
}
