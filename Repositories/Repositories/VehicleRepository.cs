using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public VehicleRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Vehicle> FeaturedVehicles => _dbContext.Vehicles.Where(x => x.IsFeatured);

        public void DeleteVehicle(string vehicleVIN)
        {
            _dbContext.Remove(_dbContext.Vehicles.Single(vr => vr.VehicleVIN == vehicleVIN));
            _dbContext.SaveChanges();
        }

        public Vehicle? FindById(string vehicleVIN)
        {
            return _dbContext.Vehicles.FirstOrDefault(vr => vr.VehicleVIN == vehicleVIN);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _dbContext.Vehicles;
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            _dbContext.Vehicles.Add(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _dbContext.Update(vehicle);
            _dbContext.SaveChanges();
        }
    }
}
