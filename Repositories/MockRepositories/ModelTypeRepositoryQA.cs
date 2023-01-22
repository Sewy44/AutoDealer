using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class ModelTypeRepositoryQA : IModelTypeRepository
    {
        public IEnumerable<ModelType> GetAll() =>
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
                    AddedDate = DateTime.Now
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
                    AddedDate = DateTime.Now
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
                    AddedDate = DateTime.Now
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
                    AddedDate = DateTime.Now
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
                    AddedDate = DateTime.Now
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
                    AddedDate = DateTime.Now
                }
            };


        public void InsertVehicleModelType(ModelType modelType)
        {
            throw new NotImplementedException();
        }
    }
}
