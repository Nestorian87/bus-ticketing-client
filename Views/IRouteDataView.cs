using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IRouteDataView : IDataView
    {

        string Title { set; }
        int? Price { get; set; }
    }
}
