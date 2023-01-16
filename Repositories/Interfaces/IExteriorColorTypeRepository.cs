using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IExteriorColorTypeRepository
    {
        IEnumerable<ExteriorColorType> GetAll();
    }
}
