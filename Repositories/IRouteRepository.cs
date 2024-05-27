using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public interface IRouteRepository
    {

        List<Route> GetAllRoutes();
        void AddRoute(Route route);
        void DeleteRoute(int routeId);
        void UpdateRoutePrice(int routeId, double price);
        List<RouteStop> GetRouteStops(int routeId);
        bool IsRouteWithActiveTickets(int routeId);
        void AddRouteStop(RouteStop routeStop);
        void DeleteRouteStop(int routeStopId);
        void UpdateRouteStop(RouteStop routeStop);
        void SwapRouteStops(int routeStopId1, int routeStopId2);
    }
}
