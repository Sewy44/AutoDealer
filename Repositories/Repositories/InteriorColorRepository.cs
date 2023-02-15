using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class InteriorColorRepository : IInteriorColorRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public InteriorColorRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<InteriorColor> GetAll()
        {
            return _dbContext.InteriorColors;
        }

        public void InsertInteriorColor(InteriorColor interiorColor)
        {
            _dbContext.InteriorColors.Add(interiorColor);
        }
    }
}
