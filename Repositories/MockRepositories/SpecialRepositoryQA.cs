using AutoDealer.Models.Special;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class SpecialRepositoryQA : ISpecialRepository
    {
        public IEnumerable<Special> GetAll() =>
            new List<Special>
            {
                new Special
                {
                    SpecialId = Guid.NewGuid(),
                    SpecialName = "Free Tires For Life!",
                    SpecialDescription = "Speak with any representative to learn how you can take advantage of"
                    + "this great offer to get free tires for the life of your vehicle!",
                    AddedBy = "jamie@autodealer.com",
                    AddedDate = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddMonths(1),

                },
                new Special
                {
                    SpecialId = Guid.NewGuid(),
                    SpecialName = "$1,000 off MSRP for any new SUV!",
                    SpecialDescription = "Come in today to purchase your new SUV and save $1,000!",
                    AddedBy = "jamie@autodealer.com",
                    AddedDate = DateTime.Now,
                    ExpirationDate = DateTime.Now.AddDays(14),
                }
            };


        public void DeleteSpecial(Guid specialId)
        {
            throw new NotImplementedException();
        }

        public void InsertSpecial(Special special)
        {
            throw new NotImplementedException();
        }
    }
}
