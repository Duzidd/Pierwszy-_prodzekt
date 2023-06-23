using Microsoft.AspNetCore.Mvc;
using Pierwszy__prodzekt.Models;
using Pierwszy__prodzekt.Services.Interface;

namespace Pierwszy__prodzekt.Controllers
{
    public class WarehouseController1 : Controller
    {
       /* private readonly IWarehouseService _warehouseService;*/
        private readonly IWarehouseService _warehouseService;

        public WarehouseController1(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }

            var id = _warehouseService.Save(body);

            TempData["ProductId"] = id;

            return RedirectToAction("list");
        }

        [HttpGet]
        public IActionResult List()
        {
            var products = _warehouseService.GetAll();
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _warehouseService.Get(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _warehouseService.Delete(id);
            return RedirectToAction("list");
        }
    }
}


