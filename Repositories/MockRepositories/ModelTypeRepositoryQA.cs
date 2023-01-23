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
                    ModelName = "Edge",
                    Make = new BrandName()
                    {
                        MakeName = "Ford"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                 new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Mustang",
                    Make = new BrandName()
                    {
                        MakeName = "Ford"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                  new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Sorrento",
                    Make = new BrandName()
                    {
                        MakeName = "Kia"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                   new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Optima",
                    Make = new BrandName()
                    {
                        MakeName = "Kia"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                    new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Grand Cherokee L",
                    Make = new BrandName()
                    {
                        MakeName = "Jeep"
                    },
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                     new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = "Wrangler",
                    Make = new BrandName()
                    {
                        MakeName = "Jeep"
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
