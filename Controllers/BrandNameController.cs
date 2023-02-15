using AutoDealer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoDealer.Controllers
{
    public class BrandNameController : Controller
    {
        private readonly IBrandRepository _brandnameRepository;

        public BrandNameController(IBrandRepository brandNameRepository)
        {
            _brandnameRepository = brandNameRepository;
        }

        public IActionResult List()
        {
            return View(_brandnameRepository.GetAll());
        }

    }
}
