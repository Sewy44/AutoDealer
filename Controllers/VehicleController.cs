using AutoDealer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoDealer.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleRepository _vehicleRecordRepository;

        public VehicleController(IVehicleRepository vehicleRecordRepository)
        {
            _vehicleRecordRepository = vehicleRecordRepository;
        }

        public ViewResult Index()
        {
            ViewBag.Message = "Welcome to AutoDealer";
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Message = "Welcome to AutoDealer";
            return View(_vehicleRecordRepository.GetAll());
        }

    }
}
