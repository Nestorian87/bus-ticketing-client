using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IStopsView : IView
    {
        Stop? SelectedStop { get; }

        event EventHandler AddStopClicked;
        event EventHandler EditStopClicked;
        event EventHandler DeleteStopClicked;

        void ShowError(string error);
        void SetStopBindingSource(BindingSource source);
        new void ShowView();
        new void CloseView();
        bool ShowConfirmation(string message);
    }
}
