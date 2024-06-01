using BusTicketingSystem.DB;
using BusTicketingSystem.Models;
using BusTicketingSystem.Presenter;
using BusTicketingSystem.Presenters;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace BusTicketingSystem
{

    internal static class Program
    {

        public static IServiceProvider ServiceProvider { get; private set; }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetupCulture();
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var dbContext = ServiceProvider.GetRequiredService<DatabaseContext>();
            dbContext.Database.EnsureCreated();

            var mainPresenter = ServiceProvider.GetRequiredService<MainPresenter>();
            mainPresenter.Run();
        }

        private static void SetupCulture()
        {
            CultureInfo culture = new CultureInfo("uk-UA");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<ApplicationContext>();
                    services.AddSingleton<DatabaseContext>();
                    services.AddTransient<IAuthRepository, AuthRepository>();
                    services.AddTransient<IUserRepository, UserRepository>();
                    services.AddTransient<IStopsRepository, StopsRepository>();
                    services.AddTransient<ITripRepository, TripRepository>();
                    services.AddTransient<ITicketRepository, TicketRepository>();
                    services.AddTransient<IBusRepository, BusRepository>();
                    services.AddTransient<IRouteRepository, RouteRepisitory>();
                    services.AddTransient<LoginPresenter>();
                    services.AddTransient<RegistrationPresenter>();
                    services.AddTransient<ILoginView, LoginForm>();
                    services.AddTransient<IRegistrationView, RegistrationForm>();
                    services.AddSingleton<MainPresenter>();
                    services.AddTransient<IMainView>(s => s.GetRequiredService<MainForm>());
                    services.AddScoped<MainForm>();
                    services.AddTransient<ISearchView>(s => s.GetRequiredService<MainForm>());
                    services.AddTransient<SearchPresenter>();
                    services.AddTransient<ITicketsView>(s => s.GetRequiredService<MainForm>());
                    services.AddTransient<TicketsPresenter>();
                    services.AddTransient<IModelsView>(s => s.GetRequiredService<MainForm>());
                    services.AddTransient<IModelDataView, ModelDataForm>();
                    services.AddTransient<ModelsPresenter>();
                    services.AddTransient<IRoutesView>(s => s.GetRequiredService<MainForm>());
                    services.AddTransient<RoutesPresenter>();
                    services.AddTransient<IRouteDataView, RouteDataForm>();
                    services.AddTransient<IRouteStopDataView, RouteStopDataForm>();
                    services.AddTransient<IRouteTripDataView, RouteTripDataForm>();
                    services.AddTransient<BusesPresenter>();
                    services.AddTransient<IBusesView>(s => s.GetRequiredService<MainForm>());
                    services.AddTransient<IBusDataView, BusDataForm>();
                    services.AddTransient<StopsPresenter>();
                    services.AddTransient<IStopsView>(s => s.GetRequiredService<MainForm>());
                    services.AddTransient<IStopDataView, StopDataForm>();

                });
        }
    }

}