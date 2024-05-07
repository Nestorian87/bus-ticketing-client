using BusTicketingSystem.Models;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.Views;

namespace BusTicketingSystem.Presenters
{
    public class SearchPresenter : IPresenter
    {

        private ISearchView view;
        private IStopsRepository stopsRepository;
        private ITripRepository tripRepository;
        private BindingSource tripBindingSource = new BindingSource();

        public SearchPresenter(ISearchView view, IStopsRepository stopsRepository, ITripRepository tripRepository) 
        { 
            this.view = view;
            this.stopsRepository = stopsRepository;
            this.tripRepository = tripRepository;

            view.SetTripBindingSource(tripBindingSource);

            view.SearchDate = view.MinSearchDate = DateTime.Now;
            view.TripsSearchClicked += (_, _) => Search();

            LoadStops();
        }

        public void Run()
        {
            view.ShowView();
        }

        private void LoadStops()
        {
            view.Stops = stopsRepository.GetAllStops();
        }

        private void Search()
        {
            List<Trip> foundTrips = tripRepository.Find(view.FromStop!, view.ToStop!, view.SearchDate);
            tripBindingSource.DataSource = foundTrips.Select(t =>
            {
                t.StartStop = view.FromStop!;
                t.EndStop = view.ToStop!;
                return t;
            }).ToList();
        }
    }
}
