using AutoDealer.Models;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class VehicleRepositoryQA : IVehicleRepository
    {
        private readonly IInteriorColorRepository _interiorColorTypeRepository = new
            InteriorColorRepositoryQA();
        private readonly IExteriorColorRepository _exteriorColorTypeRepository = new
            ExteriorColorRepositoryQA();
        private readonly IModelTypeRepository _modelTypeRepository = new
            ModelTypeRepositoryQA();

        private List<Vehicle> _vehicles = new List<Vehicle>();

        public VehicleRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var vehicleRecord in seedList)
            {
                _vehicles.Add(vehicleRecord);
            }
        }
        public IEnumerable<Vehicle> SeedRepo() =>
            new List<Vehicle>
            {
                new Vehicle
                {
                    VehicleVIN = "1C4RJFBG5FC767030",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Tan").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Black").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Edge").ModelId,
                    Mileage = 590,
                    Year = "2022",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 57000,
                    CurrentListPrice = 57000,
                    MRSP = 58500,
                    Description = "Very cool SUV!",
                    IsUsed = true
                },
                new Vehicle
                {
                    VehicleVIN = "1C4RJFBG5FC767031",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Mustang").ModelId,
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "A beautiful sports car!",
                    IsFeatured = true
                },
                new Vehicle
                {
                    VehicleVIN = "aaaaaaaaaaaaaaaaa",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Blue").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Tercel").ModelId,
                    Mileage = 360000,
                    Year = "1978",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 200,
                    CurrentListPrice = 200,
                    MRSP = 200,
                    Description = "A classic!",
                    IsFeatured = true,
                    IsUsed = true
                },
                new Vehicle
                {
                    VehicleVIN = "bbbbbbbbbbbbbbbb",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Black").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Black").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Grand Cherokee").ModelId,
                    Mileage = 2600,
                    Year = "2022",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 51500,
                    CurrentListPrice = 51500,
                    MRSP = 54500,
                    Description = "A beautiful used SUV!"
                },
                new Vehicle
                {
                    VehicleVIN = "ccccccccccccccccc",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Tan").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Silver").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Optima").ModelId,
                    Mileage = 2300,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 32000,
                    CurrentListPrice = 32000,
                    MRSP = 36400,
                    Description = "llorem Ipsum...!"
                },
                new Vehicle
                {
                    VehicleVIN = "ddddddddddddddddd",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "White").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Wrangler").ModelId,
                    Mileage = 127000,
                    Year = "2015",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 20000,
                    CurrentListPrice = 20000,
                    MRSP = 41500,
                    Description = "A great Jeep for playing outdoors!",
                    IsFeatured = true
                },
                new Vehicle
                {
                    VehicleVIN = "eeeeeeeeeeeeeeeee",
                    Transmission = Models.Enums.TransmissionType.Manual,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Black").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Black").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.SUV,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Sorrento").ModelId,
                    Mileage = 35000,
                    Year = "2020",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 23000,
                    CurrentListPrice = 23000,
                    MRSP = 41500,
                    Description = "Another kinda cool SUV!"
                },
                new Vehicle
                {
                    VehicleVIN = "fffffffffffffffff",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Mustang").ModelId,
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Could we have any more Mustangs?",
                    IsFeatured = true,
                    IsSold = false
                },
                new Vehicle
                {
                    VehicleVIN = "ggggggggggggggggg",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Mustang").ModelId,
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool SUV!",
                    IsFeatured = true,
                    IsSold = false
                },
                new Vehicle
                {
                    VehicleVIN = "hhhhhhhhhhhhhhhhh",
                    Transmission = Models.Enums.TransmissionType.Automatic,
                    InteriorColorId = _interiorColorTypeRepository.GetAll().FirstOrDefault(c => c.InteriorColorName == "Gray").InteriorColorId,
                    ExteriorColorId = _exteriorColorTypeRepository.GetAll().FirstOrDefault(c => c.ExteriorColorName == "Red").ExteriorColorId,
                    BodyStyle = Models.Enums.BodyStyleType.Car,
                    ModelId = _modelTypeRepository.GetAll().FirstOrDefault(m => m.Model == "Mustang").ModelId,
                    Mileage = 1200,
                    Year = "2021",
                    DateAdded = new DateTime(1/21/2023),
                    AddedBy = "jamie@autodealer.com",
                    OriginalListPrice = 40000,
                    CurrentListPrice = 40000,
                    MRSP = 41500,
                    Description = "Kina cool SUV!",
                    IsFeatured = true,
                    IsSold = false
                },
            };
       
        public void DeleteVehicle(string vehicleVIN)
        {
            var vehicleRecordtoDelete = GetAll().FirstOrDefault(v => v.VehicleVIN == vehicleVIN);
           
            if(vehicleRecordtoDelete != null)
            {
                _vehicles.Remove(vehicleRecordtoDelete);
            }
        }

        public Vehicle? FindById(string vehicleVIN) => GetAll().FirstOrDefault(v => v.VehicleVIN == vehicleVIN);

        public IEnumerable<Vehicle> FeaturedVehicles
        {
            get
            {
                return GetAll().Where(v => v.IsFeatured);
            }
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            if(_vehicles.FirstOrDefault(v => v.VehicleVIN == vehicle.VehicleVIN) != null)
            {
                vehicle = _vehicles.FirstOrDefault(v => v.VehicleVIN == vehicle.VehicleVIN);
            }
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return _vehicles;
        }
    }
}
