using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface ITicketsView : IView
    {
        Ticket? SelectedTicket { get; }

        event EventHandler SaveTicketClicked;
        event EventHandler ReturnTicketClicked;

        void ShowError(string error);
        void SetTicketBindingSource(BindingSource source);
        new void ShowView();
        new void CloseView();
        bool ShowReturnTicketConfirmation(string message);
        string RequestTicketSavingPath();
    }
}
