using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class ExteriorColorTypeRepositoryQA : IExteriorColorTypeRepository
    {
        private List<ExteriorColorType> _exteriorColors = new List<ExteriorColorType>();

        public ExteriorColorTypeRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _exteriorColors.Add(item);
            }
        }

        private IEnumerable<ExteriorColorType> SeedRepo() =>
            new List<ExteriorColorType>()
            {
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Red"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Black"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Silver"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "Blue"
                },
                new ExteriorColorType()
                {
                    ExteriorColorId = Guid.NewGuid(),
                    ExteriorColorName = "White"
                }
            };

        public IEnumerable<ExteriorColorType> GetAll()
        {
            return _exteriorColors;
        }

        public void InsertExteriorColor(ExteriorColorType newExteriorColor)
        {
            _exteriorColors.Add(newExteriorColor);
        }
    }
}
