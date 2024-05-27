using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem.Presenters
{
    public class RoutesPresenter : IPresenter
    {
        private readonly IRoutesView view;
        private readonly IRouteDataView routeDataView;
        private readonly IRouteStopDataView routeStopDataView;
        private readonly IRouteTripDataView routeTripDataView;
        private readonly IRouteRepository routeRepository;
        private readonly IBusRepository busRepository;
        private readonly ITripRepository tripRepository;
        private readonly IStopsRepository stopsRepository;
        private readonly BindingSource routeBindingSource = new BindingSource();
        private readonly BindingSource routeStopBindingSource = new BindingSource();
        private readonly BindingSource routeTripBindingSource = new BindingSource();
        private readonly BindingSource stopBindingSource = new BindingSource();
        private readonly BindingSource busBindingSource = new BindingSource();
        private Route? editedRoute = null;
        private RouteStop? editedRouteStop = null;
        private Trip? editedRouteTrip = null;

        public RoutesPresenter(IRoutesView view, IRouteDataView routeDataView, IRouteStopDataView routeStopDataView, IRouteTripDataView routeTripDataView,  IRouteRepository routeRepository, IBusRepository busRepository, ITripRepository tripRepository, IStopsRepository stopsRepository)
        {
            this.view = view;
            this.routeDataView = routeDataView;
            this.routeTripDataView = routeTripDataView;
            this.routeRepository = routeRepository;
            this.busRepository = busRepository;
            this.tripRepository = tripRepository;
            this.routeStopDataView = routeStopDataView;
            this.stopsRepository = stopsRepository;

            view.SetRouteBindingSource(routeBindingSource);
            view.SetRouteStopBindingSource(routeStopBindingSource);
            view.SetRouteTripBindingSource(routeTripBindingSource);
            routeStopDataView.SetStopsBindingSource(stopBindingSource);
            routeTripDataView.SetBusesBindingSource(busBindingSource);

            view.RouteSelectionChanged += (_, _) => OnRouteSelectionChanged();

            view.AddRouteClicked += (_, _) => AddRoute();
            view.EditRouteClicked += (_, _) => EditRoute();
            view.DeleteRouteClicked += (_, _) => DeleteRoute();

            view.AddRouteStopClicked += (_, _) => AddRouteStop();
            view.EditRouteStopClicked += (_, _) => EditRouteStop();
            view.DeleteRouteStopClicked += (_, _) => DeleteRouteStop();
            view.MoveRouteStopAfterClicked += (_, _) => MoveRouteStopAfter();
            view.MoveRouteStopBeforeClicked += (_, _) => MoveRouteStopBefore();

            view.AddRouteTripClicked += (_, _) => AddRouteTrip();
            view.EditRouteTripClicked += (_, _) => EditRouteTrip();
            view.DeleteRouteTripClicked += (_, _) => DeleteRouteTrip();

            routeDataView.SaveClicked += (_, _) => SaveRoute();
            routeStopDataView.SaveClicked += (_, _) => SaveRouteStop();
            routeTripDataView.SaveClicked += (_, _) => SaveTrip();

        }

        public void Run()
        {
            LoadStops();
            LoadBuses();
            ShowRoutes();
            view.ShowView();
        }

        private void LoadStops()
        {
            stopBindingSource.DataSource = stopsRepository.GetAllStops();
        }

        private void LoadBuses()
        {
            busBindingSource.DataSource = busRepository.GetAllBuses();
        }

        private void ShowRoutes()
        {
            routeBindingSource.DataSource = routeRepository.GetAllRoutes();
        }

        private void ShowRouteStops(int routeId)
        {
            routeStopBindingSource.DataSource = routeRepository.GetRouteStops(routeId);
        }

        private void ShowRouteTrips(int routeId)
        {
            routeTripBindingSource.DataSource = tripRepository.GetByRouteId(routeId);
        }


        private void OnRouteSelectionChanged()
        {
            Route? selectedRoute = view.SelectedRoute;
            if (selectedRoute != null)
            {
                ShowRouteStops(selectedRoute.Id);
                ShowRouteTrips(selectedRoute.Id);
            }
        }

        private Route? GetSelectedRoute()
        {
            Route? selectedRoute = view.SelectedRoute;
            if (selectedRoute == null)
            {
                routeDataView.ShowError("Оберіть маршрут");
                return null;
            }
            return selectedRoute;
        }

        private RouteStop? GetSelectedRouteStop()
        {
            RouteStop? selectedRouteStop = view.SelectedRouteStop;
            if (selectedRouteStop == null)
            {
                routeStopDataView.ShowError("Оберіть зупинку");
                return null;
            }
            return selectedRouteStop;
        }

        private Trip? GetSelectedRouteTrip()
        {
            Trip? selectedTrip = view.SelectedRouteTrip;
            if (selectedTrip == null)
            {
                routeTripDataView.ShowError("Оберіть рейс");
                return null;
            }
            return selectedTrip;
        }
        private void AddRouteTrip()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }

            routeTripDataView.Bus = null;
            routeTripDataView.ActiveDaysOfWeek = [];
            routeTripDataView.StartTime = TimeOnly.FromDateTime(DateTime.Now);
            routeTripDataView.ShowView();

            ShowRouteTrips(selectedRoute.Id);
        }

        private void EditRouteTrip()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            Trip? selectedTrip = GetSelectedRouteTrip();
            if (selectedTrip == null)
            {
                return;
            }

            if (tripRepository.IsTripWithActiveTickets(selectedTrip.Id))
            {
                routeDataView.ShowError("Неможливо змінити рейс, на який придбані квитки");
                return;
            }

            routeTripDataView.Bus = selectedTrip.Bus;
            routeTripDataView.ActiveDaysOfWeek = selectedTrip.ActiveDaysOfWeek;
            routeTripDataView.StartTime = selectedTrip.StartTime;

            editedRouteTrip = selectedTrip;
            routeTripDataView.ShowView();
            editedRouteTrip = null;

            ShowRouteTrips(selectedRoute.Id);
        }

        private void DeleteRouteTrip()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            Trip? selectedTrip = GetSelectedRouteTrip();
            if (selectedTrip == null)
            {
                return;
            }
            if (!view.ShowConfirmation($"Ви точно хочете видалити цей рейс?"))
            {
                return;
            }
            if (tripRepository.IsTripWithActiveTickets(selectedTrip.Id))
            {
                routeDataView.ShowError("Неможливо видалити рейс, на який придбані квитки");
                return;
            }
            tripRepository.DeleteTrip(selectedTrip.Id);
            ShowRouteTrips(selectedRoute.Id);
        }

        private void SaveTrip()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            if (!ValidateTrip())
            {
                return;
            }
            Trip trip = new Trip
            {
                Id = editedRouteTrip?.Id ?? 0,
                StartTime = routeTripDataView.StartTime,
                ActiveDaysOfWeek = routeTripDataView.ActiveDaysOfWeek,
                Bus = routeTripDataView.Bus!,
                Route = selectedRoute,
                BoughtTickets = []
            };
            if (editedRouteTrip == null)
                tripRepository.AddTrip(trip);
            else
                tripRepository.UpdateTrip(trip);

            routeTripDataView.CloseView();
        }

        private bool ValidateTrip()
        {
            if (routeTripDataView.Bus == null)
            {
                routeTripDataView.ShowError("Оберіть автобус");
                return false;
            }
            if (routeTripDataView.ActiveDaysOfWeek.Count == 0)
            {
                routeTripDataView.ShowError("Оберіть дні тижня рейсу");
                return false;
            }
            return true;
        }

        private void AddRouteStop()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            if (routeRepository.IsRouteWithActiveTickets(selectedRoute.Id))
            {
                routeDataView.ShowError("Неможливо додати зупинку на маршрут, на який придбані квитки");
                return;
            }

            routeStopDataView.Stop = null;
            routeStopDataView.StopTimeMinutes = 0;
            routeStopDataView.RideMinutesFromPreviousStop = 0;
            routeStopDataView.RideHoursFromPreviousStop = 0;
            routeStopDataView.ShowView();


            RouteStop? selectedStop = view.SelectedRouteStop;
            int oldCount = routeStopBindingSource.Count;

            ShowRoutes();
            ShowRouteStops(selectedRoute.Id);

            if (routeStopBindingSource.Count > oldCount && selectedStop != null)
            {
                view.SetSelectedRouteStopIndex(selectedStop.Index + 1);
            }
        }

        private void EditRouteStop()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            RouteStop? selectedStop = GetSelectedRouteStop();
            if (selectedStop == null)
            {
                return;
            }

            if (routeRepository.IsRouteWithActiveTickets(selectedRoute.Id))
            {
                routeDataView.ShowError("Неможливо змінити зупинку маршруту, на який придбані квитки");
                return;
            }

            routeStopDataView.Stop = selectedStop.Stop;
            routeStopDataView.StopTimeMinutes = (int) selectedStop.StayTime.TotalMinutes;
            routeStopDataView.RideMinutesFromPreviousStop = selectedStop.RideTimeFromPreviousStop.Minutes;
            routeStopDataView.RideHoursFromPreviousStop = (int) Math.Floor(selectedStop.RideTimeFromPreviousStop.TotalHours);

            editedRouteStop = selectedStop;
            routeStopDataView.ShowView();
            editedRouteStop = null;

            ShowRoutes();
            ShowRouteStops(selectedRoute.Id);
        }

        private void DeleteRouteStop()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            RouteStop? selectedStop = GetSelectedRouteStop();
            if (selectedStop == null)
            {
                return;
            }
            if (!view.ShowConfirmation($"Ви точно хочете видалити зупинку \"{selectedStop.StopName}\" з маршруту?"))
            {
                return;
            }
            if (routeRepository.IsRouteWithActiveTickets(selectedRoute.Id))
            {
                routeDataView.ShowError("Неможливо видалити зупинку з маршруту, на який придбані квитки");
                return;
            }

            routeRepository.DeleteRouteStop(selectedStop.Id);
            FixRouteStopTimes(selectedRoute.Id);

            ShowRoutes();
            ShowRouteStops(selectedRoute.Id);

            if (selectedStop.Index > 0)
            {
                view.SetSelectedRouteStopIndex(selectedStop.Index - 1);
            }
        }

        private void MoveRouteStopAfter()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            RouteStop? selectedStop = GetSelectedRouteStop();
            if (selectedStop == null)
            {
                return;
            }
            if (routeRepository.IsRouteWithActiveTickets(selectedRoute.Id))
            {
                routeDataView.ShowError("Неможливо змінити порядок зупинок маршруту, на який придбані квитки");
                return;
            }
            RouteStop? nextStop = selectedRoute.Stops
                .Where(s => s.Index == selectedStop.Index + 1)
                .FirstOrDefault();

            if (nextStop == null)
            {
                view.ShowError("Зупинка вже є останньою у маршруті");
                return;
            }
            
            routeRepository.SwapRouteStops(selectedStop.Id, nextStop.Id);
            FixRouteStopTimes(selectedRoute.Id);

            
            ShowRouteStops(selectedRoute.Id);
            view.SetSelectedRouteStopIndex(selectedStop.Index);
            ShowRoutes();
        }

        private void MoveRouteStopBefore()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            RouteStop? selectedStop = GetSelectedRouteStop();
            if (selectedStop == null)
            {
                return;
            }
            if (routeRepository.IsRouteWithActiveTickets(selectedRoute.Id))
            {
                routeDataView.ShowError("Неможливо змінити порядок зупинок маршруту, на який придбані квитки");
                return;
            }
            RouteStop? previousStop = selectedRoute.Stops
                .Where(s => s.Index == selectedStop.Index - 1)
                .FirstOrDefault();
            if (previousStop == null)
            {
                view.ShowError("Зупинка вже є першою у маршруті");
                return;
            }

            routeRepository.SwapRouteStops(selectedStop.Id, previousStop.Id);
            FixRouteStopTimes(selectedRoute.Id);

            ShowRouteStops(selectedRoute.Id);
            view.SetSelectedRouteStopIndex(selectedStop.Index);
            ShowRoutes();
        }

        private void SaveRouteStop()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            if (!ValidateRouteStop())
            {
                return;
            }

            RouteStop? stop = CreateEnteredStop(selectedRoute);
            if (stop == null)
            {
                return;
            }

            if (editedRouteStop == null)
                routeRepository.AddRouteStop(stop);
            else
                routeRepository.UpdateRouteStop(stop);

            routeStopDataView.CloseView();
        }

        private RouteStop? CreateEnteredStop(Route selectedRoute)
        {
            int index = editedRouteStop?.Index ?? (view.SelectedRouteStop?.Index ?? selectedRoute.Stops.Count - 1) + 1;
            bool isLastIndex = index == selectedRoute.Stops.Count - (editedRouteStop == null ? 0 : 1);
            bool isFirstIndex = index == 0;

            if (routeStopDataView.RideHoursFromPreviousStop != 0 ||
                routeStopDataView.RideMinutesFromPreviousStop != 0 ||
                routeStopDataView.StopTimeMinutes != 0)
            {
                string? warningText = null;

                if (isFirstIndex)
                {
                    warningText = "Час зупинки та час поїздки від попередньої " +
                        "зупинки будуть обнулені, тому що поточна зупинка стане першою у маршруті";
                }
                else if (isLastIndex && routeStopDataView.StopTimeMinutes != 0)
                {
                    warningText = "Час зупинки буде обнулено, тому що поточна зупинка стане останньою у маршруті";
                }

                if (warningText != null && !routeStopDataView.ShowConfirmationWithWarning(warningText))
                {
                    return null;
                }
            }
            if (!isFirstIndex && !isLastIndex &&
                routeStopDataView.RideHoursFromPreviousStop == 0 &&
                routeStopDataView.RideMinutesFromPreviousStop == 0)
            {
                routeStopDataView.ShowError("Введіть час поїздки від попередньої зупинки");
                return null;
            }

            return new RouteStop
            {
                Id = editedRouteStop?.Id ?? 0,
                Index = index,
                Stop = routeStopDataView.Stop!,
                RideTimeFromPreviousStop = isFirstIndex ? TimeSpan.Zero : new TimeSpan(
                    (int)routeStopDataView.RideHoursFromPreviousStop!,
                    (int)routeStopDataView.RideMinutesFromPreviousStop!, 0),
                StayTime = isFirstIndex || isLastIndex ? TimeSpan.Zero : new TimeSpan(
                    0, (int)routeStopDataView.StopTimeMinutes!, 0),
                Route = selectedRoute
            };
        }

        private bool ValidateRouteStop()
        {
            if (routeStopDataView.Stop == null)
            {
                routeStopDataView.ShowError("Оберіть зупинку");
                return false;
            }
            if (routeRepository
                .GetRouteStops(view.SelectedRoute!.Id)
                .Any(s => s.Stop.Id == routeStopDataView.Stop.Id && (editedRouteStop == null || s.Id != view.SelectedRouteStop!.Id)))
            {
                routeStopDataView.ShowError("Не можна додати одну зупинку до маршруту двічі");
                return false;
            }
            if (routeStopDataView.RideMinutesFromPreviousStop == null || routeStopDataView.RideHoursFromPreviousStop == null)
            {
                routeDataView.ShowError("Введіть час поїздки від попередньої зупинки");
                return false;
            }
            if (routeStopDataView.StopTimeMinutes == null)
            {
                routeDataView.ShowError("Введіть час зупинки");
                return false;
            }
            
        
            return true;
        }

        private void FixRouteStopTimes(int routeId)
        {
            List<RouteStop> routeStops = routeRepository.GetRouteStops(routeId);
            if (routeStops == null || routeStops.Count == 0)
            {
                return;
            }

            routeStops[0].RideTimeFromPreviousStop = TimeSpan.Zero;
            routeStops[0].StayTime = TimeSpan.Zero;
            routeRepository.UpdateRouteStop(routeStops[0]);

            routeStops[^1].StayTime = TimeSpan.Zero;
            routeRepository.UpdateRouteStop(routeStops[^1]);
        }

        private void AddRoute()
        {
            routeDataView.Title = "Пустий маршрут";
            routeDataView.Price = null;
            routeDataView.ShowView();
            ShowRoutes();
        }

        private void EditRoute()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            routeDataView.Title = selectedRoute.Name;
            routeDataView.Price = (int) Math.Round(selectedRoute.FullPrice);

            editedRoute = selectedRoute;
            routeDataView.ShowView();
            editedRoute = null;

            routeBindingSource.ResetBindings(false);
        }

        private void DeleteRoute()
        {
            Route? selectedRoute = GetSelectedRoute();
            if (selectedRoute == null)
            {
                return;
            }
            if (!view.ShowConfirmation($"Ви точно хочете видалити маршрут \"{selectedRoute.Name}\"?"))
            {
                return;
            }
            if (routeRepository.IsRouteWithActiveTickets(selectedRoute.Id))
            {
                routeDataView.ShowError("Неможливо видалити маршрут, на який придбані квитки");
                return;
            }
            routeRepository.DeleteRoute(selectedRoute.Id);
            ShowRoutes();
        }

        private void SaveRoute()
        {
            if (!ValidateRoute())
            {
                return;
            }
            if (editedRoute == null)
            {
                Route route = new Route
                {
                    FullPrice = (double)routeDataView.Price!,
                    Stops = []
                };
                routeRepository.AddRoute(route);
            }
            else
            {
                routeRepository.UpdateRoutePrice(editedRoute.Id, (double) routeDataView.Price!);
            }

            routeDataView.CloseView();
        }

        private bool ValidateRoute()
        {
            if (routeDataView.Price == null || routeDataView.Price == 0)
            {
                routeDataView.ShowError("Введіть ціну");
                return false;
            }
            return true;
        }
    }
}
