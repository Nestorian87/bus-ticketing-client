using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class Trip
    {
        public int Id { get; set; }

        public required Route Route { get; set; }

        public required Bus Bus { get; set; }

        public required TimeOnly StartTime { get; set; }

        public required List<DayOfWeek> ActiveDaysOfWeek { get; set; }

        [NotMapped]
        public required Stop StartStop { get; set; }

        [NotMapped]
        public required Stop EndStop { get; set; }

        public required List<Ticket> BoughtTickets { get; set; }

        public int AvailableSeats => Bus.Model.SeatsCount - BoughtTickets.Count;


        public string Title => Route.Name;

        public TimeOnly StartStopDepartureTime => StartTime
            .Add(Route.CalculateRideTime(StartStop))
            .Add(Route.GetStayTime(StartStop));

        public TimeOnly EndStopArrivalTime => StartStopDepartureTime.Add(RideTime);

        public string From => StartStop.Description;

        public string To => EndStop.Description;

        public TimeSpan RideTime => Route.CalculateRideTime(StartStop, EndStop);

        public double Price => Route.CalculatePrice(StartStop, EndStop);
    }
}
