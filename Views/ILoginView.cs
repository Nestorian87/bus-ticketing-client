using BusTicketingSystem.Views;

namespace BusTicketingSystem.View
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }

        event EventHandler LoginClicked;
        event EventHandler RegistrationClicked;

        void ShowError(string error);
    }
}
