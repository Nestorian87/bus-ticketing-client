using BusTicketingSystem.Models;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.Views;
using System.Data;

namespace BusTicketingSystem.Presenters
{
    public class SearchPresenter : IPresenter
    {

        private ISearchView view;
        private IStopsRepository stopsRepository;
        private ITripRepository tripRepository;
        private ITicketRepository ticketsRepository;
        private BindingSource tripBindingSource = new BindingSource();

        private Stop? lastFromStop = null;
        private Stop? lastToStop = null;
        private DateTime lastSearchDate;

        public SearchPresenter(ISearchView view, IStopsRepository stopsRepository, ITripRepository tripRepository, ITicketRepository ticketsRepository) 
        { 
            this.view = view;
            this.stopsRepository = stopsRepository;
            this.tripRepository = tripRepository;
            this.ticketsRepository = ticketsRepository;

            view.SetTripBindingSource(tripBindingSource);

            view.SearchDate = view.MinSearchDate = DateTime.Now;
            view.TripsSearchClicked += (_, _) => Search(false);
            view.BuyTicketClicked += (_, _) => BuyTicket();

            LoadStops();
        }

        public void Run()
        {
            view.ShowView();
        }

        private void LoadStops()
        {
            view.Stops = stopsRepository.GetAllStops();
            view.FromStop = null;
            view.ToStop = null;
        }

        private void Search(bool useOldData)
        {
            if (!useOldData)
            {
                lastFromStop = view.FromStop?.Copy; 
                lastToStop = view.ToStop?.Copy;
                lastSearchDate = view.SearchDate;
            }


            if (lastFromStop == null || lastToStop == null)
            {
                view.ShowError("Для пошуку рейсів необхідно обрати початкову і кінцеву точку");
                tripBindingSource.Clear();
                return;
            }

            if (lastFromStop.Id == lastToStop.Id) 
            {
                view.ShowError("Початкова і кінцева точка не можуть бути однаковими");
                tripBindingSource.Clear();
                return;
            }

            tripBindingSource.DataSource = tripRepository.Find(lastFromStop, lastToStop, lastSearchDate);
            view.IsTripsNotFoundTextVisible = tripBindingSource.Count == 0;
        }

        private void BuyTicket()
        {
            Trip? selectedTrip = view.SelectedTrip;
            int? fromStopId = lastFromStop?.Id;
            int? toStopId = lastToStop?.Id;

            if (selectedTrip == null) {
                view.ShowError("Для купівлі квитка оберіть рейс");
            }

            if (selectedTrip != null && fromStopId != null && toStopId != null)
            {
                string confirmationMessage = $"Ви точно хочете купити квиток {selectedTrip.StartStop.Name} – {selectedTrip.EndStop.Name} на {lastSearchDate.Date.ToLongDateString()} {selectedTrip.StartStopDepartureTime.ToShortTimeString()}?";
                if (view.ShowBuyingConfirmation(confirmationMessage))
                {

                    ticketsRepository.BuyTicket(
                        selectedTrip.Id,
                        (int)fromStopId,
                        (int)toStopId,
                        lastSearchDate);
                    Search(true);
                }
            }
        }
    }
}
