using System;
using System.Diagnostics;
using SalesWebMvcCs.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace SalesWebMvcCs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Essa aplicação foi desenvolvida para estudos";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Informações para contato.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
