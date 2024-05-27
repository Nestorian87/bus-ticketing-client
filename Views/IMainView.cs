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
        public event EventHandler BusesClicked;
        public event EventHandler StopsClicked;

        new void ShowView();
        new void CloseView();
        void ChangeAdminControlsVisibility(bool isVisible);

    }
}
