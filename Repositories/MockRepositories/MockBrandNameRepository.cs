using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class MockBrandNameRepository : IBrandNameRepository
    {
        public IEnumerable<BrandName> GetAll() =>
            new List<BrandName>()
            {
                new BrandName()
                {
                    BrandNameId = Guid.NewGuid(),
                    MakeName = "Ford",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = DateTime.Now
                },
                new BrandName()
                {
                    BrandNameId= Guid.NewGuid(),
                    MakeName = "Jeep",
                    AddedDate= DateTime.Now,
                    AddedBy = "jamie@Autodealer.com"
                },
                new BrandName()
                {
                    BrandNameId= Guid.NewGuid(),
                    MakeName = "Chevrolet",
                    AddedDate= DateTime.Now,
                    AddedBy = "jamie@Autodealer.com"
                },
                new BrandName()
                {
                    BrandNameId= Guid.NewGuid(),
                    MakeName = "Kia",
                    AddedDate= DateTime.Now,
                    AddedBy = "jamie@Autodealer.com"
                }
            };


        public void InsertBrandName(BrandName brandName)
        {
            throw new NotImplementedException();
        }
    }
}
