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
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Tan"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Black"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Edge"),
                    Mileage = 590,
                    Year = "2022",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 57000,
                    CurrentListPrice = 57000,
                    MRSP = 58500,
                    Description = "Very cool SUV!",
                    ImageFileName = "inventory-1C4RJFBG5FC767030.jpg"
                },
                new VehicleRecord
                {
                    VehicleVIN = "1C4RJFBG5FC767031",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "A beautiful sports car!",
                    ImageFileName = "inventory-1C4RJFBG5FC767031.jpg",
                    IsFeatured = true,
                    
                },
                new VehicleRecord
                {
                    VehicleVIN = "aaaaaaaaaaaaaaaaa",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Blue"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Tercel"),
                    Mileage = 360000,
                    Year = "1978",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 200,
                    CurrentListPrice = 200,
                    MRSP = 200,
                    Description = "A classic!",
                    ImageFileName = "inventory-aaaaaaaaaaaaaaaaa.jpg",
                    IsFeatured = true,
                },
                new VehicleRecord
                {
                    VehicleVIN = "bbbbbbbbbbbbbbbb",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Black"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Black"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Grand Cherokee"),
                    Mileage = 2600,
                    Year = "2022",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 51500,
                    CurrentListPrice = 51500,
                    MRSP = 54500,
                    Description = "A beautiful used SUV!",
                    ImageFileName = "inventory-bbbbbbbbbbbbbbbb.jpg",
                },
                new VehicleRecord
                {
                    VehicleVIN = "ccccccccccccccccc",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Tan"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Silver"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Optima"),
                    Mileage = 2300,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 32000,
                    CurrentListPrice = 32000,
                    MRSP = 36400,
                    Description = "llorem Ipsum...!",
                    ImageFileName = "inventory-ccccccccccccccccc.jpg",
                },
                new VehicleRecord
                {
                    VehicleVIN = "ddddddddddddddddd",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "White"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Wrangler"),
                    Mileage = 127000,
                    Year = "2015",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 20000,
                    CurrentListPrice = 20000,
                    MRSP = 41500,
                    Description = "A great Jeep for playing outdoors!",
                    ImageFileName = "inventory-ddddddddddddddddd.jpg",
                    IsFeatured = true,
                },
                new VehicleRecord
                {
                    VehicleVIN = "eeeeeeeeeeeeeeeee",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Black"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Black"),
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Sorrento"),
                    Mileage = 35000,
                    Year = "2020",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 23000,
                    CurrentListPrice = 23000,
                    MRSP = 41500,
                    Description = "Another kinda cool SUV!",
                    ImageFileName = "inventory-eeeeeeeeeeeeeeeee.jpg",
                },
                new VehicleRecord
                {
                    VehicleVIN = "fffffffffffffffff",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Could we have any more Mustangs?",
                    ImageFileName = "inventory-fffffffffffffffff.jpg",
                    IsFeatured = true,
                    IsSold = false,
                },
                new VehicleRecord
                {
                    VehicleVIN = "ggggggggggggggggg",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool SUV!",
                    ImageFileName = "inventory-ggggggggggggggggg.jpg",
                    IsFeatured = true,
                    IsSold = false,
                },
                new VehicleRecord
                {
                    VehicleVIN = "hhhhhhhhhhhhhhhhh",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColor = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray"),
                    ExteriorColor = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red"),
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    Model = _modelTypeRepository.GetAll().FirstOrDefault(m => m.ModelName == "Mustang"),
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool SUV!",
                    ImageFileName = "inventory-hhhhhhhhhhhhhhhhh.jpg",
                    IsFeatured = true,
                    IsSold = false,
                },
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
