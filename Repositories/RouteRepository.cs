using BusTicketingSystem.DB;
using BusTicketingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Eventing.Reader;

namespace BusTicketingSystem.Repositories
{
    public class RouteRepisitory(DatabaseContext dbContext) : IRouteRepository
    {
        public void AddRoute(Route route)
        {
            dbContext.Routes.Add(route);
            dbContext.SaveChanges();
        }

        public void AddRouteStop(RouteStop routeStop)
        {
            FreeIndexForRouteStop(routeStop);
            dbContext.RouteStops.Add(routeStop);
            dbContext.SaveChanges();
        }

        public void DeleteRoute(int routeId)
        {
            Route? route = GetRoute(routeId);
            if (route == null)
            {
                return;
            }
            dbContext.Routes.Remove(route);
            dbContext.SaveChanges();
        }

        public void DeleteRouteStop(int routeStopId)
        {
            RouteStop? routeStop = GetRouteStop(routeStopId);
            if (routeStop == null)
            {
                return;
            }
            dbContext.RouteStops.Remove(routeStop);

            dbContext.SaveChanges();

            List<RouteStop> stops = GetRouteStops(routeStop.Route.Id);
            for (int i = 0; i < stops.Count; i++)
            {
                stops[i].Index = i;
            }

            dbContext.SaveChanges();
        }

        public List<Route> GetAllRoutes()
        {
            return dbContext.Routes.Include(r => r.Stops).ToList();
        }

        private Route? GetRoute(int routeId)
        {
            return dbContext.Routes.Find(routeId);
        }

        private RouteStop? GetRouteStop(int routeStopId)
        {
            return dbContext.RouteStops.Find(routeStopId);
        }

        public List<RouteStop> GetRouteStops(int routeId)
        {
            return dbContext
                .Routes
                .Where(r => r.Id == routeId)
                .SelectMany(r => r.Stops)
                .OrderBy(s => s.Index)
                .ToList();
        }

        public bool IsRouteWithActiveTickets(int routeId)
        {
            return dbContext.Tickets
                .Where(t => t.Date >= DateOnly.FromDateTime(DateTime.Now) && t.Trip.Route.Id == routeId)
                .Any();
        }

        public void UpdateRoutePrice(int routeId, double price)
        {
            Route? route = GetRoute(routeId);
            if (route == null) 
            {
                return;
            }
            route.FullPrice = price;
            dbContext.SaveChanges();
        }

        public void UpdateRouteStop(RouteStop routeStop)
        {
            RouteStop? currentStop = GetRouteStop(routeStop.Id);
            if (currentStop == null)
            {
                return;
            }
            if (currentStop.Index != routeStop.Index)
            {
                FreeIndexForRouteStop(routeStop);
            }
            currentStop.CopyFrom(routeStop);
            dbContext.SaveChanges();
        }

      

        private void FreeIndexForRouteStop(RouteStop routeStop)
        {
            foreach (RouteStop stop in GetRouteStops(routeStop.Route.Id).Where(s => s.Index >= routeStop.Index && s.Id != routeStop.Id))
            {
                stop.Index++;
            }
        }

        public void SwapRouteStops(int routeStopId1, int routeStopId2)
        {
            RouteStop? stop1 = GetRouteStop(routeStopId1);
            RouteStop? stop2 = GetRouteStop(routeStopId2);
            if (stop1 == null || stop2 == null || stop1.Route.Id != stop2.Route.Id)
            {
                throw new InvalidOperationException("Both stops must exist and belong to the same route");
            }
            (stop2.Index, stop1.Index) = (stop1.Index, stop2.Index);
            dbContext.SaveChanges();
        }
    }
}
