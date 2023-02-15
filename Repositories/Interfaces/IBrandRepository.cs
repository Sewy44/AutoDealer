using AutoDealer.Models.VehicleComponents;

namespace AutoDealer.Repositories.Interfaces
{
    public interface IBrandRepository
    {
        IEnumerable<Brand> GetAll();
        void InsertBrand(Brand brandName);
    }
}
