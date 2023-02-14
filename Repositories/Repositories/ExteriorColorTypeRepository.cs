using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class ExteriorColorTypeRepository : IExteriorColorTypeRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public ExteriorColorTypeRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ExteriorColorType> GetAll()
        {
            return _dbContext.ExteriorColors;
        }

        public void InsertExteriorColor(ExteriorColorType newExteriorColor)
        {
            _dbContext.ExteriorColors.Add(newExteriorColor);
        }
    }
}
