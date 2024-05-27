using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class Bus
    {
        public int Id { get; set; }
       
        public required BusModel Model { get; set; }

        public required string Number { get; set; }

        public string Info => $"{Number} ({Model.Name})";
    }
}
