using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface ISearchView : IView
    {
        Stop? FromStop { get; set; }
        Stop? ToStop { get; set; }
        DateTime SearchDate { set;  get; }
        DateTime MinSearchDate { set; }
        List<Stop> Stops { set; }
        Trip? SelectedTrip { get; }
        bool IsTripsNotFoundTextVisible { set; }

        event EventHandler TripsSearchClicked;
        event EventHandler BuyTicketClicked;

        void ShowError(string error);
        void SetTripBindingSource(BindingSource source);
        bool ShowBuyingConfirmation(string message);
        new void ShowView();
        new void CloseView();
    }
}
