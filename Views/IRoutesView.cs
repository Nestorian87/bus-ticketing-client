using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IRoutesView : IView
    {
        Route? SelectedRoute { get; }
        RouteStop? SelectedRouteStop { get; }
        Trip? SelectedRouteTrip { get; }

        event EventHandler AddRouteClicked;
        event EventHandler EditRouteClicked;
        event EventHandler DeleteRouteClicked;
        event EventHandler RouteSelectionChanged;

        event EventHandler AddRouteStopClicked;
        event EventHandler EditRouteStopClicked;
        event EventHandler DeleteRouteStopClicked;
        event EventHandler MoveRouteStopBeforeClicked;
        event EventHandler MoveRouteStopAfterClicked;

        event EventHandler AddRouteTripClicked;
        event EventHandler EditRouteTripClicked;
        event EventHandler DeleteRouteTripClicked;


        void ShowError(string error);
        void SetRouteBindingSource(BindingSource source);
        void SetRouteStopBindingSource(BindingSource source);
        void SetRouteTripBindingSource(BindingSource source);
        void SetSelectedRouteStopIndex(int index);
        new void ShowView();
        new void CloseView();
        bool ShowConfirmation(string message);
    }
}
