using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using BusTicketingSystem.Presenters;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using Microsoft.Extensions.DependencyInjection;

namespace BusTicketingSystem.Presenter
{
    public class RegistrationPresenter : IPresenter
    {
        private readonly IRegistrationView view;
        private readonly IAuthRepository authRepository;

        public RegistrationPresenter(IRegistrationView view, IAuthRepository authRepository)
        {
            this.view = view;
            this.authRepository = authRepository;

            view.RegisterClicked += (_, _) => Register();
            view.BackArrowClicked += (_, _) => OpenLogin();
        }

        public void Run()
        {
            view.ShowView();
        }

        private void Register()
        {
            if (!ValidateFields())
            {
                return;
            }

            if (!authRepository.IsUsernameAvailable(view.Username))
            {
                view.ShowError("Таке ім'я користувача вже використовується");
                return;
            }

            User user = new User(view.Name, view.Surname, view.Username, view.Password);
            authRepository.Register(user);
            OpenMainScreen();
        }

        private void OpenLogin()
        {
            var loginPresenter = Program.ServiceProvider.GetRequiredService<LoginPresenter>();
            loginPresenter.Run();
            view.CloseView();
        }

        private void OpenMainScreen()
        {
            var mainPresenter = Program.ServiceProvider.GetRequiredService<MainPresenter>();
            mainPresenter.Run();
            view.CloseView();
        }

        private bool ValidateFields()
        {
            if (view.Name.Length == 0)
            {
                view.ShowError("Введіть ім'я");
                return false;
            }
            if (view.Surname.Length == 0)
            {
                view.ShowError("Введіть прізвище");
                return false;
            }
            if (view.Username.Length == 0)
            {
                view.ShowError("Введіть ім'я користувача");
                return false;
            }
            if (view.Password.Length == 0)
            {
                view.ShowError("Введіть пароль");
                return false;
            }

            return true;
        }
    }
}