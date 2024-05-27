using BusTicketingSystem.Views;

namespace BusTicketingSystem.View
{
    public interface IMainView : IView
    {

        public event EventHandler LogoutClicked;
        public event EventHandler SearchTripsClicked;
        public event EventHandler MyTicketsClicked;
        public event EventHandler ModelsClicked;
        public event EventHandler RoutesClicked;

        new void ShowView();
        new void CloseView();
        void ChangeAdminControlsVisibility(bool isVisible);

    }
}
