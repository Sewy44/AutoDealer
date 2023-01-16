using AutoDealer.Models.Special;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockSpecialRepository : ISpecialRepository
    {
        public void DeleteSpecial(Guid specialId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Special> GetAll()
        {
            throw new NotImplementedException();
        }

        public void InsertSpecial(Special special)
        {
            throw new NotImplementedException();
        }
    }
}
