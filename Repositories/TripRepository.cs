using BusTicketingSystem.DB;
using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public class TripRepository(DatabaseContext dbContext) : ITripRepository
    {
        public List<Trip> Find(Stop fromStop, Stop toStop, DateTime date)
        {
            return dbContext.Routes
                .Where(r => r.Stops.Any(s => s.Stop.Id == fromStop.Id) &&
                    r.Stops.Any(s => s.Stop.Id == toStop.Id) &&
                    r.Stops.First(s => s.Stop.Id == fromStop.Id).Index < r.Stops.First(s => s.Stop.Id == toStop.Id).Index)
                .Include(r => r.Stops)
                .Include(r => r.Trips)
                .Include(r => r.Trips).ThenInclude(t => t.Bus).ThenInclude(b => b.Model)
                .ToList()
                .SelectMany(r => r.Trips)
                .Where(t => t.ActiveDaysOfWeek.Contains(date.DayOfWeek) && t.AvailableSeats > 0)
                .ToList();
        }
    }
}
