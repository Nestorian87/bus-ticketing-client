using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IModelsView : IView
    {
        BusModel? SelectedModel { get; }

        event EventHandler AddModelClicked;
        event EventHandler EditModelClicked;
        event EventHandler DeleteModelClicked;

        void ShowError(string error);
        void SetModelsBindingSource(BindingSource source);
        new void ShowView();
        new void CloseView();
        bool ShowConfirmation(string message);
    }
}
