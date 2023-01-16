using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IModelTypeRepository
    {
        IEnumerable<ModelType> GetAll();
        void InsertVehicleModelType(ModelType modelType);
    }
}
