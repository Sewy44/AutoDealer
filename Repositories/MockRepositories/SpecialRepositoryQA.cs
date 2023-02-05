using AutoDealer.Models.Special;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class SpecialRepositoryQA : ISpecialRepository
    {
        private List<Special> _specials = new List<Special>();
        private DateTime _addedDate = new DateTime(2023, 1, 1);

        public SpecialRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var special in seedList)
            {
                _specials.Add(special);
            }
        }
        public IEnumerable<Special> SeedRepo() =>
            new List<Special>
            {
                new Special
                {
                    SpecialId = Guid.NewGuid(),
                    SpecialName = "Free Tires For Life!",
                    SpecialDescription = "Speak with any representative to learn how you can take advantage of"
                    + "this great offer to get free tires for the life of your vehicle!",
                    AddedBy = "jamie@autodealer.com",
                    AddedDate = _addedDate,
                    ExpirationDate = DateTime.Now.AddMonths(1),
                    ImageFileName = "tires.jpg"
                },
                new Special
                {
                    SpecialId = Guid.NewGuid(),
                    SpecialName = "$1,000 off MSRP for any new SUV!",
                    SpecialDescription = "Come in today to purchase your new SUV and save $1,000!",
                    AddedBy = "jamie@autodealer.com",
                    AddedDate = _addedDate,
                    ExpirationDate = DateTime.Now.AddDays(14),
                    ImageFileName = "tires.jpg"
                }
            };

        public void DeleteSpecial(Guid specialId)
        {
            var specialToDelete = GetAll().FirstOrDefault(s => s.Equals(specialId));

            if(specialToDelete != null)
            {
                _specials.Remove(specialToDelete);
            }
          
        }

        public void InsertSpecial(Special special)
        {
            _specials.Add(special);
        }

        public IEnumerable<Special> GetAll()
        {
            return _specials;
        }
    }
}
