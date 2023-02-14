using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class InteriorColorTypeRepository : IInteriorColorTypeRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public InteriorColorTypeRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<InteriorColorType> GetAll()
        {
            return _dbContext.InteriorColors;
        }

        public void InsertInteriorColor(InteriorColorType interiorColor)
        {
            _dbContext.InteriorColors.Add(interiorColor);
        }
    }
}
