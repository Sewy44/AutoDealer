using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class VehicleRecordRepository : IVehicleRecordRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public VehicleRecordRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<VehicleRecord> FeaturedVehicles => _dbContext.VehicleRecords.Where(x => x.IsFeatured);

        public void DeleteVehicleRecord(string vehicleVIN)
        {
            _dbContext.Remove(_dbContext.VehicleRecords.Single(vr => vr.VehicleVIN == vehicleVIN));
            _dbContext.SaveChanges();
        }

        public VehicleRecord? FindById(string vehicleVIN)
        {
            return _dbContext.VehicleRecords.FirstOrDefault(vr => vr.VehicleVIN == vehicleVIN);
        }

        public IEnumerable<VehicleRecord> GetAll()
        {
            return _dbContext.VehicleRecords;
        }

        public void InsertVehicleRecord(VehicleRecord vehicleRecord)
        {
            _dbContext.VehicleRecords.Add(vehicleRecord);
        }

        public void UpdateVehicleRecord(VehicleRecord vehicleRecord)
        {
            _dbContext.Update(vehicleRecord);
            _dbContext.SaveChanges();
        }
    }
}
