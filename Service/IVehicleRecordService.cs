using AutoDealer.Models;

namespace AutoDealer
{
    public interface IVehicleRecordService
    {
        IEnumerable<VehicleRecord> GetAll();
    }
}
