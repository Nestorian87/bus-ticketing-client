using BusTicketingSystem.DB;
using BusTicketingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BusTicketingSystem.Repositories
{
    class BusRepository(DatabaseContext dbContext) : IBusRepository
    {
        public void AddModel(BusModel model)
        {
            dbContext.BusModels.Add(model);
            dbContext.SaveChanges();
        }

        public void DeleteModel(int modelId)
        {
            BusModel? model = dbContext.BusModels.Find(modelId);
            if (model == null)
            {
                return;
            }
            dbContext.BusModels.Remove(model);
            dbContext.SaveChanges();
        }

        public List<BusModel> GetAllModels()
        {
            return dbContext.BusModels.OrderBy(m => m.Name).ToList();
        }

        public BusModel? GetModel(int modelId)
        {
            return dbContext.BusModels.Find(modelId);
        }

        public void UpdateModel(BusModel model)
        {
            GetModel(model.Id)?.CopyFrom(model);
            dbContext.SaveChanges();
        }

        public bool IsBusesWithModelOnRoute(int modelId)
        {
            return dbContext.Trips.Any(t => t.Bus.Model.Id == modelId);
        }
    }
}
