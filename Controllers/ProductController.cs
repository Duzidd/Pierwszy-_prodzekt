using Microsoft.AspNetCore.Mvc;
using Pierwszy__prodzekt.Models;
using Pierwszy__prodzekt.Services.Interface;
using System.Security.Cryptography.X509Certificates;

namespace Pierwszy__prodzekt.Controllers
{
    public class ProductController : Controller

    {
        private readonly IWarehouseService _warehouseService;

        public ProductController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "samochód",
                Description = "to jest m3",
                Name = "BMW"
            };
            return View(product);

        }
        public IActionResult list()
        {
            var productsList = _warehouseService.GetAll();
            {
                return View(productsList);
            }
        }
            public IActionResult Data()
            {

                ViewBag.Name = '1';
                ViewData["DUPA"] = "yyy";
                TempData["DUPADWA"] = "TO JEST TEST NA PRODZIE xd";
                return View();
            }

        }
    } 
