using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IBusDataView : IDataView
    {

        BusModel? Model { get; set; }
        string Number { get; set; }

        void SetModelBindingSource(BindingSource source);

    }
}
