using BusTicketingSystem.DB;
using BusTicketingSystem.Presenter;
using BusTicketingSystem.Presenters;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var mainPresenter = ServiceProvider.GetRequiredService<MainPresenter>();
            mainPresenter.Run();
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
                    services.AddTransient<LoginPresenter>();
                    services.AddTransient<RegistrationPresenter>();
                    services.AddTransient<ILoginView, LoginForm>();
                    services.AddTransient<IRegistrationView, RegistrationForm>();
                    services.AddTransient<IMainView, MainForm>();
                    services.AddTransient<MainPresenter>();
                });
        }
    }

}