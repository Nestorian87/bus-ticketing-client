using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Repositories
{
    public interface IBusRepository
    {
        List<BusModel> GetAllModels();
        BusModel? GetModel(int id);
        void AddModel(BusModel model);
        void UpdateModel(BusModel model);
        void DeleteModel(int modelId);
        bool AreBusesWithModelOnRoute(int modelId);
        bool IsBusOnRoute(int modelId);
        List<Bus> GetAllBuses();
        void DeleteBus(int busId);
        void AddBus(Bus bus);
        void UpdateBus(Bus bus);
    }
}
