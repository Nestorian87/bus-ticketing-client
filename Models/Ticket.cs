﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Trip Trip { get; set; }

        public DateOnly Date { get; set; }

        public RouteStop StartStop { get; set; }

        public RouteStop EndStop { get; set; }

        public Ticket(User user, Trip trip, DateOnly date, RouteStop startStop, RouteStop endStop)
        {
            User = user;
            Trip = trip;
            Date = date;
            StartStop = startStop;
            EndStop = endStop;
        }

        public Ticket()
        {
        }
    }
}
