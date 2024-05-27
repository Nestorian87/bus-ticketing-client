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
            BusModel? model = GetModel(modelId);
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

        private BusModel? GetModel(int modelId)
        {
            return dbContext.BusModels.Find(modelId);
        }

        private Bus? GetBus(int busId)
        {
            return dbContext.Buses.Find(busId);
        }

        public void UpdateModel(BusModel model)
        {
            GetModel(model.Id)?.CopyFrom(model);
            dbContext.SaveChanges();
        }

        public bool AreBusesWithModelOnRoute(int modelId)
        {
            return dbContext.Trips.Any(t => t.Bus.Model.Id == modelId);
        }

        public bool IsBusOnRoute(int busId)
        {
            return dbContext.Trips.Any(t => t.Bus.Id == busId);
        }

        public List<Bus> GetAllBuses()
        {
            return dbContext.Buses.Include(b => b.Model).ToList();
        }

        public void DeleteBus(int busId)
        {
            Bus? bus = GetBus(busId);
            if (bus == null)
            {
                return;
            }
            dbContext.Buses.Remove(bus);
            dbContext.SaveChanges();
        }

        BusModel? IBusRepository.GetModel(int id)
        {
            throw new NotImplementedException();
        }

        public void AddBus(Bus bus)
        {
            dbContext.Buses.Add(bus);
            dbContext.SaveChanges();
        }

        public void UpdateBus(Bus bus)
        {
            GetBus(bus.Id)?.CopyFrom(bus);
            dbContext.SaveChanges();
        }
    }
}
