using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class InteriorColorTypeRepositoryQA : IInteriorColorTypeRepository
    {
        private List<InteriorColorType> _interiorColors = new List<InteriorColorType>();

        public InteriorColorTypeRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _interiorColors.Add(item);
            }
        }
        public IEnumerable<InteriorColorType> SeedRepo() =>
            new List<InteriorColorType>()
            {
                new InteriorColorType()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Black"
                },
                new InteriorColorType()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Tan"
                },
                new InteriorColorType()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "White"
                },
                new InteriorColorType()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Gray"
                }
            };

        public void InsertInteriorColor(InteriorColorType interiorColor)
        {
            _interiorColors.Add(interiorColor);
        }

        public IEnumerable<InteriorColorType> GetAll()
        {
            return _interiorColors;
        }
    }
}
