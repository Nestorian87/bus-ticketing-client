using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IRouteStopDataView : IDataView
    {
        Stop? Stop { get; set; }
        int? RideHoursFromPreviousStop { get; set; }
        int? RideMinutesFromPreviousStop { get; set; }
        int? StopTimeMinutes {  get; set; }
        
        void SetStopsBindingSource(BindingSource bindingSource);
        bool ShowConfirmationWithWarning(string message);
    }
}
