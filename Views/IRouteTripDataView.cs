using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IRouteTripDataView : IDataView
    {
        Bus? Bus { get; set; }
        TimeOnly StartTime { get; set; }
        List<DayOfWeek> ActiveDaysOfWeek { get; set; }

        void SetBusesBindingSource(BindingSource bindingSource);
    }
}
