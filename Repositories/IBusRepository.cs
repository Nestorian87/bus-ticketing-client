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
        bool IsBusesWithModelOnRoute(int modelId);
    }
}
