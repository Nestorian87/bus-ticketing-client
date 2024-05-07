using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class BusModel
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int SeatsCount { get; set; }
    }
}
