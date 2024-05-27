using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IBusesView : IView
    {
        Bus? SelectedBus { get; }

        event EventHandler AddBusClicked;
        event EventHandler EditBusClicked;
        event EventHandler DeleteBusClicked;

        void ShowError(string error);
        void SetBusBindingSource(BindingSource source);
        new void ShowView();
        new void CloseView();
        bool ShowConfirmation(string message);
    }
}
