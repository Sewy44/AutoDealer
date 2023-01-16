using AutoDealer.Models;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IVehicleRecordRepository
    {
        IEnumerable<VehicleRecord> GetAll();
        VehicleRecord? FindById(Guid vehicleRecordId);
        void InsertVehicleRecord(VehicleRecord vehicleRecord);
        void UpdateVehicleRecord(VehicleRecord vehicleRecord);
        void DeleteVehicleRecord(Guid vehicleRecordId);
    }
}
