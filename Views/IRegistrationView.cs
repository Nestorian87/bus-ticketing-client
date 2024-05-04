using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IRegistrationView : IView
    {
        string Name { get; }
        string Surname { get; }
        string Username {  get; }
        string Password { get; }

        event EventHandler BackArrowClicked;
        event EventHandler RegisterClicked;

        void ShowError(string error);
    }
}
