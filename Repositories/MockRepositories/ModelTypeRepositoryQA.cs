using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class ModelTypeRepositoryQA : IModelTypeRepository
    {
        private List<ModelType> _models = new List<ModelType>();

        private DateTime _addedDate = new DateTime(2023, 1, 1);

        public ModelTypeRepositoryQA()
        {
            var seedList = SeedRepo();

            foreach(var item in seedList)
            {
                _models.Add(item);
            }
        }
        public IEnumerable<ModelType> SeedRepo() =>
            new List<ModelType>()
            {
                new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Edge",
                    Brand = new Brand()
                    {
                        BrandName = "Ford"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                 new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Mustang",
                    Brand = new Brand()
                    {
                        BrandName = "Ford"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                  new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Sorrento",
                    Brand = new Brand()
                    {
                        BrandName = "Kia"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                   new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Optima",
                    Brand = new Brand()
                    {
                        BrandName = "Kia"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                    new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Grand Cherokee L",
                    Brand = new Brand()
                    {
                        BrandName = "Jeep"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                     new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Wrangler",
                    Brand = new Brand()
                    {
                        BrandName = "Jeep"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                      new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "ForeRunner",
                    Brand = new Brand()
                    {
                        BrandName = "Toyota"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                       new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Tercel",
                    Brand = new Brand()
                    {
                        BrandName = "Toyota"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                }

            };


        public void InsertVehicleModelType(ModelType modelType)
        {
            _models.Add(modelType);
        }

        public IEnumerable<ModelType> GetAll()
        {
            return _models;
        }
    }
}
