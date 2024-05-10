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
                .Include(r => r.Trips).ThenInclude(t => t.Bus).ThenInclude(b => b.Model)
                .ToList()
                .SelectMany(r => r.Trips)
                .Where(t => t.ActiveDaysOfWeek.Contains(date.DayOfWeek))
                .ToList()
                .Select(trip =>
                {
                    RouteStop startStop = trip.Route.Stops.Find(s => s.Stop.Id == fromStop.Id)!;
                    RouteStop endStop = trip.Route.Stops.Find(s => s.Stop.Id == toStop.Id)!;

                    List<Ticket> tickets = dbContext
                    .Tickets
                    .Where(ticket => ticket.Trip.Id == trip.Id)
                    .Where(ticket => ticket.Date == DateOnly.FromDateTime(date))
                    .Where(ticket =>
                        ticket.EndStop.Index > startStop.Index && ticket.StartStop.Index < endStop.Index)
                    .ToList();

                    trip.BoughtTickets = tickets;
                    trip.StartStop = fromStop;
                    trip.EndStop = toStop;

                    return trip;
                })
                .Where(t => t.AvailableSeats > 0)
                .Where(t => t.StartStopDepartureTime > TimeOnly.FromDateTime(DateTime.Now))
                .OrderBy(t => t.StartStopDepartureTime)
                .ToList();
        }
    }
}
