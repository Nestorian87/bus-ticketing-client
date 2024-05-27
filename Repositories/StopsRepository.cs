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
        public void AddStop(Stop stop)
        {
            dbContext.Stops.Add(stop);
            dbContext.SaveChanges();
        }

        public void DeleteStop(int stopId)
        {
            Stop? stop = GetStop(stopId);
            if (stop == null)
            {
                return;
            }
            dbContext.Stops.Remove(stop);
            dbContext.SaveChanges();
        }

        public List<Stop> GetAllStops()
        {
            return dbContext.Stops.ToList();
        }

        public bool IsStopUsedOnRoutes(int stopId)
        {
            return dbContext.Routes.SelectMany(r => r.Stops).Any(s => s.Stop.Id == stopId);
        }

        public void UpdateStop(Stop stop)
        {
            GetStop(stop.Id)?.CopyFrom(stop);
            dbContext.SaveChanges();
        }

        private Stop? GetStop(int stopId)
        {
            return dbContext.Stops.Find(stopId);
        }
    }
}
