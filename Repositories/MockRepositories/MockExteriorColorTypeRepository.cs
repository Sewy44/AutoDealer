using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockExteriorColorTypeRepository : IExteriorColorTypeRepository
    {
        public IEnumerable<ExteriorColorType> GetAll() =>
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
    }
}
