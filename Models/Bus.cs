﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Number { get; set; }
        public int TotalSeats { get; set; }
    }
}
