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
    public class BusesPresenter : IPresenter
    {
        private readonly IBusesView view;
        private readonly IBusDataView dataView;
        private readonly IBusRepository busRepository;
        private readonly BindingSource busBindingSource = new BindingSource();
        private readonly BindingSource modelBindingSource = new BindingSource();
        private Bus? editedBus = null;

        public BusesPresenter(IBusesView view, IBusDataView dataView, IBusRepository busRepository)
        {
            this.view = view;
            this.busRepository = busRepository;
            this.dataView = dataView;

            view.SetBusBindingSource(busBindingSource);
            dataView.SetModelBindingSource(modelBindingSource);

            view.AddBusClicked += (_, _) => AddBus();
            view.EditBusClicked += (_, _) => EditBus();
            view.DeleteBusClicked += (_, _) => DeleteBus();

            dataView.SaveClicked += (_, _) => SaveBus();
        }

        public void Run()
        {
            ShowBuses();
            LoadModels();
            view.ShowView();
        }

        private void ShowBuses()
        {
            busBindingSource.DataSource = busRepository.GetAllBuses();
        }

        private void LoadModels()
        {
            modelBindingSource.DataSource = busRepository.GetAllModels();
        }            

        private Bus? GetSelectedBus()
        {
            Bus? selectedBus = view.SelectedBus;
            if (selectedBus == null)
            {
                dataView.ShowError("Оберіть автобус");
                return null;
            }
            return selectedBus;
        }

        private void AddBus()
        {
            dataView.Model = null;
            dataView.Number = "";
            dataView.ShowView();
            ShowBuses();
        }

        private void EditBus()
        {
            Bus? selectedBus = GetSelectedBus();
            if (selectedBus == null)
            {
                return;
            }

            dataView.Model = selectedBus.Model;
            dataView.Number = selectedBus.Number;

            editedBus = selectedBus;
            dataView.ShowView();
            editedBus = null;

            busBindingSource.ResetBindings(false);
        }

        private void DeleteBus()
        {
            Bus? selectedBus = GetSelectedBus();
            if (selectedBus == null)
            {
                return;
            }
            if (!view.ShowConfirmation($"Ви точно хочете видалити автобус \"{selectedBus.Number}\"?"))
            {
                return;
            }
            if (busRepository.IsBusOnRoute(selectedBus.Id))
            {
                dataView.ShowError("Неможливо видалити автобус, який знаходиться на маршруті");
                return;
            }
            busRepository.DeleteBus(selectedBus.Id);
            ShowBuses();
        }

        private void SaveBus()
        {
            if (!ValidateBus())
            {
                return;
            }
            Bus bus = new()
            {
                Id = editedBus?.Id ?? 0,
                Model = dataView.Model!,
                Number = dataView.Number
            };

            if (editedBus == null)
                busRepository.AddBus(bus);
            else
                busRepository.UpdateBus(bus);
            
            dataView.CloseView();
        }

        private bool ValidateBus()
        {
            if (dataView.Model == null)
            {
                dataView.ShowError("Оберіть модель автобуса");
                return false;
            }
            if (string.IsNullOrEmpty(dataView.Number))
            {
                dataView.ShowError("Введіть номер автобуса");
                return false;
            }

            if (editedBus != null && 
                editedBus.Model.Id != dataView.Model.Id &&
                busRepository.IsBusOnRoute(editedBus.Id))
            {
                dataView.ShowError("Неможливо змінити модель автобуса, який знаходиться на маршруті");
                return false;
            }

            if (busRepository
                .GetAllBuses()
                .Any(b => b.Number == dataView.Number && (editedBus == null || b.Id != view.SelectedBus!.Id)))
            {
                dataView.ShowError("Автобус з таким номером вже існує");
                return false;
            }

            return true;
        }
    }
}
