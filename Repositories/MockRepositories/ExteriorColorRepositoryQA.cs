using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class ExteriorColorRepositoryQA : IExteriorColorRepository
    {
        private List<ExteriorColor> _exteriorColors = new List<ExteriorColor>();

        public ExteriorColorRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _exteriorColors.Add(item);
            }
        }

        private IEnumerable<ExteriorColor> SeedRepo() =>
            new List<ExteriorColor>()
            {
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Red"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Black"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Silver"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Blue"
                },
                new ExteriorColor()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "White"
                }
            };

        public IEnumerable<ExteriorColor> GetAll()
        {
            return _exteriorColors;
        }

        public void InsertExteriorColor(ExteriorColor newExteriorColor)
        {
            _exteriorColors.Add(newExteriorColor);
        }
    }
}
