using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
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
        public Stop StartStop { get; set; } = null!;

        [NotMapped]
        public Stop EndStop { get; set; } = null!;

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

        public string BusInfo => $"{Bus.Number}\n({Bus.Model.Name})";

        public string ActiveDaysOfWeekString
        {
            get
            {
                var cultureInfo = new CultureInfo("uk-UA");
                var dateTimeFormat = cultureInfo.DateTimeFormat;

                return string.Join(", ", ActiveDaysOfWeek.Select(dateTimeFormat.GetAbbreviatedDayName));
            }
        }

        public void CopyFrom(Trip other)
        {
            Id = other.Id;
            Route = other.Route;
            Bus = other.Bus;
            StartTime = other.StartTime;
            ActiveDaysOfWeek = other.ActiveDaysOfWeek;
            StartStop = other.StartStop;
            EndStop = other.EndStop;
            BoughtTickets = other.BoughtTickets;
        }
    }
}
