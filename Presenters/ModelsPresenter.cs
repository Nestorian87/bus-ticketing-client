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
    public class ModelsPresenter : IPresenter
    {
        private readonly IModelsView view;
        private readonly IModelDataView dataView;
        private readonly IBusRepository busRepository;
        private readonly BindingSource modelsBindingSource = new BindingSource();
        private BusModel? editedModel = null;

        public ModelsPresenter(IModelsView view, IModelDataView dataView, IBusRepository busRepository)
        {
            this.view = view;
            this.busRepository = busRepository;
            this.dataView = dataView;

            view.SetModelsBindingSource(modelsBindingSource);

            view.AddModelClicked += (_, _) => AddModel();
            view.EditModelClicked += (_, _) => EditModel();
            view.DeleteModelClicked += (_, _) => DeleteModel();

            dataView.SaveClicked += (_, _) => SaveModel();
        }

        public void Run()
        {
            ShowModels();
            view.ShowView();
        }

        private void ShowModels()
        {
            modelsBindingSource.DataSource = busRepository.GetAllModels();
        }

        private BusModel? GetSelectedModel()
        {
            BusModel? selectedModel = view.SelectedModel;
            if (selectedModel == null)
            {
                dataView.ShowError("Оберіть модель");
                return null;
            }
            return selectedModel;
        }

        private void AddModel()
        {
            dataView.ModelName = "";
            dataView.SeatsCount = null;
            dataView.ShowView();
            ShowModels();
        }

        private void EditModel()
        {
            BusModel? selectedModel = GetSelectedModel();
            if (selectedModel == null)
            {
                return;
            }
            dataView.ModelName = selectedModel.Name;
            dataView.SeatsCount = selectedModel.SeatsCount;

            editedModel = selectedModel;
            dataView.ShowView();
            editedModel = null;

            modelsBindingSource.ResetBindings(false);
        }

        private void DeleteModel()
        {
            BusModel? selectedModel = GetSelectedModel();
            if (selectedModel == null)
            {
                return;
            }
            if (!view.ShowConfirmation($"Ви точно хочете видалити модель \"{selectedModel.Name}\"?"))
            {
                return;
            }
            if (busRepository.IsBusesWithModelOnRoute(selectedModel.Id))
            {
                dataView.ShowError("Неможливо видалити модель, автобуси якої знаходяться на маршруті");
                return;
            }
            busRepository.DeleteModel(selectedModel.Id);
            ShowModels();
        }

        private void SaveModel()
        {
            if (!ValidateModel())
            {
                return;
            }
            BusModel model = new()
            {
                Id = editedModel?.Id ?? 0,
                Name = dataView.ModelName,
                SeatsCount = (int) dataView.SeatsCount!
            };

            if (editedModel == null)
                busRepository.AddModel(model);
            else
                busRepository.UpdateModel(model);
            
            dataView.CloseView();
        }

        private bool ValidateModel()
        {
            if (string.IsNullOrEmpty(dataView.ModelName))
            {
                dataView.ShowError("Введіть назву");
                return false;
            }
            if (dataView.SeatsCount == null || dataView.SeatsCount == 0)
            {
                dataView.ShowError("Введіть кількість місць");
                return false;
            }

            if (editedModel != null && 
                editedModel.SeatsCount > dataView.SeatsCount &&
                busRepository.IsBusesWithModelOnRoute(editedModel.Id))
            {
                dataView.ShowError("Неможливо зменшити кількість місць у моделі, автобуси якої знаходяться на маршруті");
                return false;
            }

            return true;
        }
    }
}
