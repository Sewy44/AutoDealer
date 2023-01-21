using Microsoft.AspNetCore.Mvc;

namespace AutoDealer.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleRecordService _vehicleRecordService;

        public VehicleController(IVehicleRecordService vehicleRecordService)
        {
            _vehicleRecordService = vehicleRecordService;
        }

        public ViewResult Index()
        {
            ViewBag.Message = "Welcome to AutoDealer";
            return View();
        }

        public IActionResult List()
        {
            return View(_vehicleRecordService.GetAll);
        }

    }
}
