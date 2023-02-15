using AutoDealer.Models;
using AutoDealer.Models.Special;

namespace AutoDealer.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Special>? Specials { get; }
        public IEnumerable<Vehicle> FeaturedVehicles { get; }

        public HomeIndexViewModel(IEnumerable<Special> specials, IEnumerable<Vehicle> featuredVehicles)
        {
            Specials = specials;
            FeaturedVehicles = featuredVehicles;
        }

    }
}
