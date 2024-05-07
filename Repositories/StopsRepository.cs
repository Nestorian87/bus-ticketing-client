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
    public class StopsRepository(DatabaseContext dbContext) : IStopsRepository
    {
        public List<Stop> GetAllStops()
        {
            return dbContext.Stops.ToList();
        }
    }
}
