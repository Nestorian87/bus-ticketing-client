using BusTicketingSystem.Presenter;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing.Interop;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Presenters
{
    public class MainPresenter : IPresenter
    {

        private readonly IMainView view;
        private readonly IUserRepository userRepository;
        private readonly SearchPresenter searchPresenter;

        public MainPresenter(IMainView view, IUserRepository userRepository, SearchPresenter searchPresenter, TicketsPresenter ticketsPresenter, ModelsPresenter modelsPresenter)
        {
            this.view = view;
            this.userRepository = userRepository;
            this.searchPresenter = searchPresenter;


            view.LogoutClicked += (_, _) => Logout();
            view.SearchTripsClicked += (_, _) => searchPresenter.Run();
            view.MyTicketsClicked += (_, _) => ticketsPresenter.Run();
            view.ModelsClicked += (_, _) => modelsPresenter.Run();
            

            view.ChangeAdminControlsVisibility(userRepository.GetCurrentUser()?.IsAdmin == true);
        }

        public void Run()
        {
            if (userRepository.GetCurrentUser() == null)
            {
                OpenLogin();
                return;
            }
            searchPresenter.Run();
            view.ShowView();
        }

        private void OpenLogin()
        {
            var loginPresenter = Program.ServiceProvider.GetRequiredService<LoginPresenter>();
            loginPresenter.Run();
            view.CloseView();
        }

        private void Logout()
        {
            userRepository.Logout();
            OpenLogin();
        }
    }
}
