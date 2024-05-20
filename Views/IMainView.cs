using BusTicketingSystem.Views;

namespace BusTicketingSystem.View
{
    public interface IMainView : IView
    {

        public event EventHandler LogoutClicked;
        public event EventHandler SearchTripsClicked;
        public event EventHandler MyTicketsClicked;

        new void ShowView();
        new void CloseView();

    }
}
