using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockInteriorColorTypeRepository : IInteriorColorTypeRepository
    {
        public IEnumerable<InteriorColorType> GetAll() =>
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
    }
}
