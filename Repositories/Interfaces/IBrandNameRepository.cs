using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IBrandNameRepository
    {
        IEnumerable<BrandName> GetAll();
        void InsertBrandName(BrandName brandName);
    }
}
