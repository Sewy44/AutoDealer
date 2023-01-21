using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockVehicleRecordRepository : IVehicleRecordRepository
    {
        private readonly IInteriorColorTypeRepository _interiorColorTypeRepository = new
            MockInteriorColorTypeRepository();
        private readonly IExteriorColorTypeRepository _exteriorColorTypeRepository = new
            MockExteriorColorTypeRepository();
        private readonly IModelTypeRepository _modelTypeRepository = new
            MockModelTypeRepository();
        public IEnumerable<VehicleRecord> GetAll() =>
            new List<VehicleRecord>
            {
                new VehicleRecord
                {
                    VehicleVIN = "1C4RJFBG5FC767030",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().ToList()[0],
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().ToList()[0],
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = _modelTypeRepository.GetAll().ToList()[0],
                    Mileage = 590,
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 57000,
                    CurrentListPrice = 57000,
                    MRSP = 58500,
                    Description = "Very cool SUV!",
                    ImageFileName = null,
                    IsFeatured = false,
                    IsSold = false,
                },
                new VehicleRecord
                {
                    VehicleVIN = "1C4RJFBG5FC767031",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().ToList()[1],
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().ToList()[1],
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = _modelTypeRepository.GetAll().ToList()[1],
                    Mileage = 1200,
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool SUV!",
                    ImageFileName = null,
                    IsFeatured = true,
                    IsSold = false,
                }
            };
       
        public void DeleteVehicleRecord(string vehicleVIN)
        {
            throw new NotImplementedException();
        }

        public VehicleRecord? FindById(string vehicleVIN) => GetAll().FirstOrDefault(v => v.VehicleVIN == vehicleVIN);

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
