using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem.Presenters
{
    public class StopsPresenter : IPresenter
    {
        private readonly IStopsView view;
        private readonly IStopDataView dataView;
        private readonly IStopsRepository stopsRepository;
        private readonly BindingSource stopBindingSource = new BindingSource();
        private Stop? editedStop = null;

        public StopsPresenter(IStopsView view, IStopDataView dataView, IStopsRepository stopsRepository)
        {
            this.view = view;
            this.stopsRepository = stopsRepository;
            this.dataView = dataView;

            view.SetStopBindingSource(stopBindingSource);

            view.AddStopClicked += (_, _) => AddStop();
            view.EditStopClicked += (_, _) => EditStop();
            view.DeleteStopClicked += (_, _) => DeleteStop();

            dataView.SaveClicked += (_, _) => SaveStop();
        }

        public void Run()
        {
            ShowStops();
            view.ShowView();
        }

        private void ShowStops()
        {
            stopBindingSource.DataSource = stopsRepository.GetAllStops();
        }  

        private Stop? GetSelectedStop()
        {
            Stop? selectedStop = view.SelectedStop;
            if (selectedStop == null)
            {
                dataView.ShowError("Оберіть зупинку");
                return null;
            }
            return selectedStop;
        }

        private void AddStop()
        {
            dataView.StopName = "";
            dataView.Address = "";
            dataView.ShowView();
            ShowStops();
        }

        private void EditStop()
        {
            Stop? selectedStop = GetSelectedStop();
            if (selectedStop == null)
            {
                return;
            }

            dataView.StopName = selectedStop.Name;
            dataView.Address = selectedStop.Address;

            editedStop = selectedStop;
            dataView.ShowView();
            editedStop = null;

            stopBindingSource.ResetBindings(false);
        }

        private void DeleteStop()
        {
            Stop? selectedStop = GetSelectedStop();
            if (selectedStop == null)
            {
                return;
            }
            if (!view.ShowConfirmation($"Ви точно хочете видалити зупинку \"{selectedStop.Name}\"?"))
            {
                return;
            }
            if (stopsRepository.IsStopUsedOnRoutes(selectedStop.Id))
            {
                dataView.ShowError("Неможливо видалити зупинку, через яку прокладені маршрути");
                return;
            }
            stopsRepository.DeleteStop(selectedStop.Id);
            ShowStops();
        }

        private void SaveStop()
        {
            if (!ValidateStop())
            {
                return;
            }
            Stop stop = new()
            {
                Id = editedStop?.Id ?? 0,
                Name = dataView.StopName,
                Address = dataView.Address
            };

            if (editedStop == null)
                stopsRepository.AddStop(stop);
            else
                stopsRepository.UpdateStop(stop);
            
            dataView.CloseView();
        }

        private bool ValidateStop()
        {
            if (string.IsNullOrEmpty(dataView.StopName))
            {
                dataView.ShowError("Введіть назву зупинки");
                return false;
            }
            if (string.IsNullOrEmpty(dataView.Address))
            {
                dataView.ShowError("Введіть адресу зупинки");
                return false;
            }

            if (stopsRepository
                .GetAllStops()
                .Any(s => string.Equals(s.Name, dataView.StopName, StringComparison.OrdinalIgnoreCase) &&
                    (editedStop == null || s.Id != view.SelectedStop!.Id)))
            {
                dataView.ShowError("Зупинка з такою назвою вже існує");
                return false;
            }

            return true;
        }
    }
}
