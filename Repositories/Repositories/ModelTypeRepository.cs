using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{ 
    public class ModelTypeRepository : IModelTypeRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public ModelTypeRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ModelType> GetAll()
        {
            return _dbContext.Models;
        }

        public void InsertVehicleModelType(ModelType modelType)
        {
            _dbContext.Models.Add(modelType);
        }
    }
}
