using AutoDealer.Models;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IVehicleRecordRepository
    {
        IEnumerable<VehicleRecord> GetAll();
        VehicleRecord? FindById(string vehicleVIN);
        void InsertVehicleRecord(VehicleRecord vehicleRecord);
        void UpdateVehicleRecord(VehicleRecord vehicleRecord);
        void DeleteVehicleRecord(VehicleRecord vehicleRecord);
        IEnumerable<VehicleRecord> GetFeaturedVehicles();
    }
}
