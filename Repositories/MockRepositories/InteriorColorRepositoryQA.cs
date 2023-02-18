using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class InteriorColorRepositoryQA : IInteriorColorRepository
    {
        private List<InteriorColor> _interiorColors = new List<InteriorColor>();

        public InteriorColorRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _interiorColors.Add(item);
            }
        }
        public IEnumerable<InteriorColor> SeedRepo() =>
            new List<InteriorColor>()
            {
                new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Black"
                },
                new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Tan"
                },
                new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "White"
                },
                new InteriorColor()
                {
                    InteriorColorId = Guid.NewGuid(),
                    InteriorColorName = "Gray"
                }
            };

        public void InsertInteriorColor(InteriorColor interiorColor)
        {
            _interiorColors.Add(interiorColor);
        }

        public IEnumerable<InteriorColor> GetAll()
        {
            return _interiorColors;
        }
    }
}
