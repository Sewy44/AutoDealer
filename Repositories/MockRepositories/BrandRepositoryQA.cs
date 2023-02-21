using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class BrandRepositoryQA : IBrandRepository
    {
        private readonly List<Brand> _brandNames = new List<Brand>();
        private readonly DateTime _addedDate = new DateTime(2023,1,22);

        public BrandRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _brandNames.Add(item);
            }
        }

        private IEnumerable<Brand> SeedRepo() =>
            new List<Brand>()
            {
                new Brand()
                {
                    BrandNameId = Guid.NewGuid(),
                    BrandName = "Ford",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                new Brand()
                {
                    BrandNameId= Guid.NewGuid(),
                    BrandName = "GMC",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new Brand()
                {
                    BrandNameId= Guid.NewGuid(),
                    BrandName = "Toyota",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                new Brand()
                {
                    BrandNameId= Guid.NewGuid(),
                    BrandName = "Kia",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                },
                 new Brand()
                {
                    BrandNameId= Guid.NewGuid(),
                    BrandName = "Jeep",
                    AddedDate= _addedDate,
                    AddedBy = "jamie@Autodealer.com"
                }
            };

        public IEnumerable<Brand> GetAll()
        {
            return _brandNames;
        }
        public void InsertBrand(Brand brandName)
        {
            _brandNames.Add(brandName);
        }
    }
}
