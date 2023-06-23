using Microsoft.AspNetCore.Mvc;
using Pierwszy__prodzekt.Models;
using System.Diagnostics;

namespace Pierwszy__prodzekt.Controllers
{
    public class HomeController : Controller
    {
    

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Redirect()
        {
            return RedirectToAction("Privacy");
        }
       public IActionResult Product(string name)
        {
            return View();
        }


    }
}