using AutoDealer.Models.Special;

namespace AutoDealer.Repositories.Interfaces
{
    public interface ISpecialRepository
    {
        IEnumerable<Special> GetAll();
        void DeleteSpecial(Guid specialId);
        void InsertSpecial(Special special);
    }
}
