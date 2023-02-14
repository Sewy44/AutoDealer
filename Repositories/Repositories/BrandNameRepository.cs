using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class BrandNameRepository : IBrandNameRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public BrandNameRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<BrandName> GetAll()
        {
            return _dbContext.BrandNames;   
        }

        public void InsertBrandName(BrandName brandName)
        {
            _dbContext.BrandNames.Add(brandName);
        }
    }
}
