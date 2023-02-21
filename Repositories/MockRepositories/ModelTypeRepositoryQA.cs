using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class ModelTypeRepositoryQA : IModelTypeRepository
    {
        private readonly List<ModelType> _models = new List<ModelType>();

        private readonly DateTime _addedDate = new DateTime(2023, 1, 1);

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
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                 new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Mustang",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                  new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Sorrento",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                   new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Optima",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                    new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Grand Cherokee L",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                     new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Wrangler",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                      new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "ForeRunner",
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                       new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Tercel",
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
