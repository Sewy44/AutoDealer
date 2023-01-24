using AutoDealer.Models;
using AutoDealer.Models.Special;

namespace AutoDealer.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Special>? Specials { get; }
        public IEnumerable<VehicleRecord> FeaturedVehicles { get; }

        public HomeIndexViewModel(IEnumerable<Special> specials, IEnumerable<VehicleRecord> featuredVehicles)
        {
            Specials = specials;
            FeaturedVehicles = featuredVehicles;
        }

    }
}
