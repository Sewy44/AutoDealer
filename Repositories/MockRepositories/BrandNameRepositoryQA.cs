using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class BrandNameRepositoryQA : IBrandNameRepository
    {
        private List<BrandName> _brandNames = new List<BrandName>();
        private static DateTime _addedDate = new DateTime(2023,1,22);

        public BrandNameRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _brandNames.Add(item);
            }
        }

        private IEnumerable<BrandName> SeedRepo() =>
            new List<BrandName>()
            {
                new BrandName()
                {
                    BrandNameId = Guid.NewGuid(),
                    MakeName = "Ford",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new BrandName()
                {
                    BrandNameId= Guid.NewGuid(),
                    MakeName = "GMC",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new BrandName()
                {
                    BrandNameId= Guid.NewGuid(),
                    MakeName = "Toyota",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new BrandName()
                {
                    BrandNameId= Guid.NewGuid(),
                    MakeName = "Kia",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                 new BrandName()
                {
                    BrandNameId= Guid.NewGuid(),
                    MakeName = "Dodge",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                }
            };

        public IEnumerable<BrandName> GetAll()
        {
            return _brandNames;
        }
        public void InsertBrandName(BrandName brandName)
        {
            _brandNames.Add(brandName);
        }
    }
}
