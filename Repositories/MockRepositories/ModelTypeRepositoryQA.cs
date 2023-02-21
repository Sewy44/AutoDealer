using AutoDealer.Models.VehicleComponents;
using AutoDealer.Repositories.Interfaces;

namespace AutoDealer.Repositories.MockRepositories
{
    public class ModelTypeRepositoryQA : IModelTypeRepository
    {
        private readonly IBrandRepository _brandRepository = new BrandRepositoryQA();
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
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Ford").BrandNameId,
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                 new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Mustang",
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Ford").BrandNameId,
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                  new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Sorrento",
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Kia").BrandNameId,
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                   new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Optima",
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Kia").BrandNameId,
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                    new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Grand Cherokee L",
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Jeep").BrandNameId,
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                     new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Wrangler",
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Jeep").BrandNameId,
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                      new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "ForeRunner",
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Toyota").BrandNameId,
                    AddedBy = "jamie@Autodealer.com",
                    AddedDate = _addedDate
                },
                       new ModelType()
                {
                    ModelId = Guid.NewGuid(),
                    Model = "Tercel",
                    BrandNameId = _brandRepository.GetAll().FirstOrDefault(b => b.BrandName == "Toyota").BrandNameId,
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
