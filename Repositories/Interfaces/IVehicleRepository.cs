using AutoDealer.Models;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetAll();
        Vehicle? FindById(string vehicleVIN);
        void InsertVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
        void DeleteVehicle(string vehicleVIN);
        IEnumerable<Vehicle> FeaturedVehicles { get; }
    }
}
