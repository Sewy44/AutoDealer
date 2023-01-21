using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Service
{
    public class VehicleRecordService : IVehicleRecordService
    {
        private readonly IVehicleRecordRepository _vehicleRecordRepository;

        public VehicleRecordService(IVehicleRecordRepository vehicleRecordRepository)
        {
            _vehicleRecordRepository = vehicleRecordRepository;
        }

        public IEnumerable<VehicleRecord> GetAll()
        {
            return _vehicleRecordRepository.GetAll();
        }
    }
}
