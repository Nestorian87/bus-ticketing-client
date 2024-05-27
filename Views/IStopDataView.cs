using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IStopDataView : IDataView
    {

        string StopName { get; set; }
        string Address { get; set; }
    }
}
