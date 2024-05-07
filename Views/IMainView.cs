using BusTicketingSystem.Views;

namespace BusTicketingSystem.View
{
    public interface IMainView : IView
    {

        public event EventHandler LogoutClicked;

        new void ShowView();
        new void CloseView();

    }
}
