using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class Route
    {
        public int Id { get; set; }

        public double FullPrice { get; set; }

        private List<RouteStop> _stops = null!;

        public required List<RouteStop> Stops {
            get => _stops;
            set => _stops = value.OrderBy(s => s.Index).ToList();
        }

        public List<Trip> Trips { get; set; } = null!;

        public string Name => $"{Stops.First().Stop.Name} – {Stops.Last().Stop.Name}";

        public TimeSpan CalculateRideTime(Stop endStop)
        {
            return CalculateRideTime(Stops.First().Stop, endStop);
        }

        public TimeSpan GetStayTime(Stop stop)
        {
            return Stops.Find(s => s.Stop.Id == stop.Id)!.StayTime;
        }

        public TimeSpan CalculateRideTime(Stop startStop, Stop endStop)
        {
            TimeSpan rideTime = TimeSpan.Zero;
            bool isStartStopFound = false;

            foreach (var stop in Stops)
            {
                bool isEndStop = endStop.Id == stop.Stop.Id;

                if (isStartStopFound)
                {
                    rideTime += stop.RideTimeFromPreviousStop;
                    if (!isEndStop)
                    {
                        rideTime += stop.StayTime;
                    }
                }

                if (startStop.Id == stop.Stop.Id)
                {
                    isStartStopFound = true;
                }

                if (isEndStop)
                {
                    break;
                }
            }

            return rideTime;
        }

        public double CalculatePrice(Stop startStop, Stop endStop)
        {
            TimeSpan fullTime = CalculateRideTime(Stops.First().Stop, Stops.Last().Stop);
            TimeSpan rideTime = CalculateRideTime(startStop, endStop);

            return rideTime / fullTime * FullPrice;
        }
    }
}
