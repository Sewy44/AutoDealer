using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class ExteriorColorRepository : IExteriorColorRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public ExteriorColorRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ExteriorColor> GetAll()
        {
            return _dbContext.ExteriorColors;
        }

        public void InsertExteriorColor(ExteriorColor newExteriorColor)
        {
            _dbContext.ExteriorColors.Add(newExteriorColor);
        }
    }
}
