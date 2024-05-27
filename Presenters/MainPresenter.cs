using BusTicketingSystem.Models;
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

        public MainPresenter(
            IMainView view,
            IUserRepository userRepository,
            SearchPresenter searchPresenter,
            TicketsPresenter ticketsPresenter,
            ModelsPresenter modelsPresenter,
            RoutesPresenter routesPresenter,
            BusesPresenter busesPresenter,
            StopsPresenter stopsPresenter)
        {
            this.view = view;
            this.userRepository = userRepository;
            this.searchPresenter = searchPresenter;


            view.LogoutClicked += (_, _) => Logout();
            view.SearchTripsClicked += (_, _) => searchPresenter.Run();
            view.MyTicketsClicked += (_, _) => ticketsPresenter.Run();
            view.ModelsClicked += (_, _) => modelsPresenter.Run();
            view.RoutesClicked += (_, _) => routesPresenter.Run();
            view.BusesClicked += (_, _) => busesPresenter.Run();
            view.StopsClicked += (_, _) => stopsPresenter.Run();
        }

        public void Run()
        {
            User? currentUser = userRepository.GetCurrentUser();
            if (currentUser == null)
            {
                OpenLogin();
                return;
            }
            searchPresenter.Run();

            view.ChangeAdminControlsVisibility(currentUser.IsAdmin);
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
