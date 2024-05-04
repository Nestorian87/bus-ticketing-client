using BusTicketingSystem.Presenter;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Presenters
{
    public class MainPresenter : IPresenter
    {

        private readonly IMainView view;
        private readonly IUserRepository userRepository;

        public MainPresenter(IMainView view, IUserRepository userRepository)
        {
            this.view = view;
            this.userRepository = userRepository;

            view.LogoutClicked += (_, _) => Logout();
        }

        public void Run()
        {
            if (userRepository.GetCurrentUser() == null)
            {
                OpenLogin();
                return;
            }
            view.Show();
        }

        private void OpenLogin()
        {
            var loginPresenter = Program.ServiceProvider.GetRequiredService<LoginPresenter>();
            loginPresenter.Run();
            view.Close();
        }

        private void Logout()
        {
            userRepository.Logout();
            OpenLogin();
        }
    }
}
