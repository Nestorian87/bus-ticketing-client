using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using BusTicketingSystem.Presenters;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusTicketingSystem.Presenter
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView view;
        private readonly IAuthRepository authRepository;
        private readonly IUserRepository userRepository;

        public LoginPresenter(
            ILoginView view, IAuthRepository authRepository, IUserRepository userRepository)
        {
            this.view = view;
            this.authRepository = authRepository;
            this.userRepository = userRepository;

            view.LoginClicked += (_, _) => Login();
            view.RegistrationClicked += (_, _) => OpenRegistration();
        }

        public void Run()
        {
            view.ShowView();
        }

        private void Login()
        {
            if (!ValidateFields())
            {
                return;
            }

            User? user = userRepository.GetUserByUsername(view.Username);
            if (user == null)
            {
                view.ShowError("Користувач не знайдений");
                return;
            }


            bool isCorrectPassword = PasswordHashingManager.VerifyPassword(
                view.Password, user.PasswordHash
            );
            if (!isCorrectPassword)
            {
                view.ShowError("Неправильний пароль");
                return;
            }

            authRepository.Login(user);
            OpenMainScreen();
        }

        private void OpenRegistration()
        {
            var registrationPresenter = Program.ServiceProvider.GetRequiredService<RegistrationPresenter>();
            registrationPresenter.Run();
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