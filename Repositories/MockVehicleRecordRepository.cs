using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories
{
    public class MockVehicleRecordRepository : IVehicleRecordRepository
    {
        public IEnumerable<VehicleRecord> GetAll()
        {
            throw new NotImplementedException();
        }
        public void DeleteVehicleRecord(Guid vehicleRecordId)
        {
            throw new NotImplementedException();
        }

        public VehicleRecord? FindById(Guid vehicleRecordId) => GetAll().FirstOrDefault(v => v.VehicleRecordId == vehicleRecordId);


        public IEnumerable<VehicleRecord> GetFeaturedVehicles
        {
            get
            {
                return GetAll().Where(v => v.IsFeatured);
            }
        }

        public void InsertVehicleRecord(VehicleRecord vehicleRecord)
        {
            throw new NotImplementedException();
        }

        public void UpdateVehicleRecord(VehicleRecord vehicleRecord)
        {
            throw new NotImplementedException();
        }
    }
}
