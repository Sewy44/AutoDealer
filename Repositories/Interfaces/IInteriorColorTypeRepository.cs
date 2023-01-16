using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IInteriorColorTypeRepository
    {
        IEnumerable<InteriorColorType> GetAll();
    }
}
