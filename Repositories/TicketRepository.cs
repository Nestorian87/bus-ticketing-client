using BusTicketingSystem.DB;
using BusTicketingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTicketingSystem.Repositories
{
    internal class TicketRepository(DatabaseContext dbContext, IUserRepository userRepository) : ITicketRepository
    {
        public void BuyTicket(int tripId, int startStopId, int endStopId, DateTime date)
        {
            Trip trip = dbContext
                .Trips
                .Where(t => t.Id == tripId)
                .Include(t => t.Route).ThenInclude(r => r.Stops)
                .FirstOrDefault() 
                ?? throw new ArgumentException($"Trip with id {tripId} does not exist");

            User user = userRepository.GetCurrentUser() 
                ?? throw new Exception("There is no logged user");

            RouteStop startStop = trip
                .Route
                .Stops
                .Find(s => s.Stop.Id == startStopId)
                ?? throw new ArgumentException($"Stop with id {startStopId} does not exist"); ;

            RouteStop endStop = trip
                .Route
                .Stops
                .Find(s => s.Stop.Id == endStopId)
                ?? throw new ArgumentException($"Stop with id {endStopId} does not exist");

            Ticket ticket = new(user, trip, DateOnly.FromDateTime(date), startStop, endStop);
            dbContext.Tickets.Add(ticket);
            dbContext.SaveChanges();
        }

        public List<Ticket> GetActiveTickets()
        {
            User user = userRepository.GetCurrentUser()
                ?? throw new Exception("There is no logged user");

            return dbContext.Tickets
                .Where(t => t.User.Id == user.Id && t.Date >= DateOnly.FromDateTime(DateTime.Now))
                .Include(t => t.Trip).ThenInclude(tr => tr.Route).ThenInclude(r => r.Stops)
                .Include(t => t.Trip).ThenInclude(tr => tr.Bus).ThenInclude(b => b.Model)
                .Include(t => t.StartStop)
                .Include(t => t.EndStop)
                .ToList();
        }
    }
}
