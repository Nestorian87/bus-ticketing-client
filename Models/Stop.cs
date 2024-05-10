using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Models
{
    public class Stop
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Address { get; set; }

        public string Description => $"{Name}, {Address}";

        public Stop Copy => new() { Id = Id, Name = Name, Address = Address };

    }
}
