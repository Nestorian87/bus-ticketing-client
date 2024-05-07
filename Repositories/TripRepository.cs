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
    public class TripRepository(DatabaseContext dbContext) : ITripRepository
    {
        public List<Trip> Find()
        {
            return dbContext.Routes
                .Include(r => r.Stops)
                .Include(r => r.Trips)
                .ToList()
                .SelectMany(r => r.Trips)
                .ToList();
        }
    }
}
