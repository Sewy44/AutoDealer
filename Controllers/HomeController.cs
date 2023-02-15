using AutoDealer.Repositories.Interfaces;
using AutoDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AutoDealer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpecialRepository _specialsRepository;
        private readonly IVehicleRepository _vehicleRecordRepository;

        public HomeController(ISpecialRepository specialRepository, IVehicleRepository vehicleRecordRepository)
        {
            _specialsRepository = specialRepository;
            _vehicleRecordRepository = vehicleRecordRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel(_specialsRepository.GetAll(), _vehicleRecordRepository.FeaturedVehicles);
            return View(model);
        }
    }
}
