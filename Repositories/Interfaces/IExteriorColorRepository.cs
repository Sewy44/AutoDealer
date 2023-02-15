using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IExteriorColorRepository
    {
        IEnumerable<ExteriorColor> GetAll();
        void InsertExteriorColor(ExteriorColor newExteriorColor);
    }
}
