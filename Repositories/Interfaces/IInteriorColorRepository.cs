using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IInteriorColorRepository
    {
        IEnumerable<InteriorColor> GetAll();
        void InsertInteriorColor(InteriorColor interiorColor);
    }
}
