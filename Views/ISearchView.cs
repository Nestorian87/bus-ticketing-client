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
        Stop? FromStop { get; }
        Stop? ToStop { get; }
        DateTime SearchDate { set;  get; }
        DateTime MinSearchDate { set; }
        List<Stop> Stops { set; }

        event EventHandler TripsSearchClicked;

        void ShowError(string error);
        void SetTripBindingSource(BindingSource source);
        new void ShowView();
        new void CloseView();
    }
}
