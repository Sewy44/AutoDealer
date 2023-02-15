using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public BrandRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Brand> GetAll()
        {
            return _dbContext.Brands;   
        }

        public void InsertBrand(Brand brandName)
        {
            _dbContext.Brands.Add(brandName);
        }
    }
}
