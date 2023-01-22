using AutoDealer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoDealer.Controllers
{
    public class BrandNameController : Controller
    {
        private readonly IBrandNameRepository _brandnameRepository;

        public BrandNameController(IBrandNameRepository brandNameRepository)
        {
            _brandnameRepository = brandNameRepository;
        }

        public IActionResult List()
        {
            return View(_brandnameRepository.GetAll());
        }

    }
}
