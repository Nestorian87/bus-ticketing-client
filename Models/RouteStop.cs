using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class RouteStop
    {
        public int Id { get; set; }

        public int Index { get; set; }

        public required Stop Stop { get; set; }

        public TimeSpan RideTimeFromPreviousStop { get; set; }

        public TimeSpan StayTime {  get; set; }
    }
}
