using AutoDealer.Models.Special;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.Repositories
{
    public class SpecialRepository : ISpecialRepository
    {
        private readonly AutoDealerDbContext _dbContext;

        public SpecialRepository(AutoDealerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteSpecial(Guid specialId)
        {
            _dbContext.Remove(_dbContext.Specials.Single(s => s.SpecialId == specialId));
            _dbContext.SaveChanges();
        }

        public IEnumerable<Special> GetAll()
        {
            return _dbContext.Specials;
        }

        public void InsertSpecial(Special special)
        {
            _dbContext.Specials.Add(special);
        }
    }
}
