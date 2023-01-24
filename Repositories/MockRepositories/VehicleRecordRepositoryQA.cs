using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class VehicleRecordRepositoryQA : IVehicleRecordRepository
    {
        private readonly IInteriorColorTypeRepository _interiorColorTypeRepository = new
            InteriorColorTypeRepositoryQA();
        private readonly IExteriorColorTypeRepository _exteriorColorTypeRepository = new
            ExteriorColorTypeRepositoryQA();
        private readonly IModelTypeRepository _modelTypeRepository = new
            ModelTypeRepositoryQA();

        private List<VehicleRecord> _vehicleRecords = new List<VehicleRecord>();

        public VehicleRecordRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var vehicleRecord in seedList)
            {
                _vehicleRecords.Add(vehicleRecord);
            }
        }
        public IEnumerable<VehicleRecord> SeedRepo() =>
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
                    Year = "2022",
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
                    Year = "2021",
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
            var vehicleRecordtoDelete = GetAll().FirstOrDefault(v => v.VehicleVIN == vehicleVIN);
           
            if(vehicleRecordtoDelete != null)
            {
                _vehicleRecords.Remove(vehicleRecordtoDelete);
            }
        }

        public VehicleRecord? FindById(string vehicleVIN) => GetAll().FirstOrDefault(v => v.VehicleVIN == vehicleVIN);

        public IEnumerable<VehicleRecord> FeaturedVehicles
        {
            get
            {
                return GetAll().Where(v => v.IsFeatured);
            }
        }

        public void InsertVehicleRecord(VehicleRecord vehicleRecord)
        {
            _vehicleRecords.Add(vehicleRecord);
        }

        public void UpdateVehicleRecord(VehicleRecord vehicleRecord)
        {
            if(_vehicleRecords.FirstOrDefault(v => v.VehicleVIN == vehicleRecord.VehicleVIN) != null)
            {
                vehicleRecord = _vehicleRecords.FirstOrDefault(v => v.VehicleVIN == vehicleRecord.VehicleVIN);
            }
        }

        public IEnumerable<VehicleRecord> GetAll()
        {
            return _vehicleRecords;
        }
    }
}
