using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.WebMVC.Models;
using TouristProject.WebMVC.Models.Nutrients;

namespace TouristProject.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INutrientService _nutrientService;

        public HomeController(ILogger<HomeController> logger, INutrientService nutrientService)
        {
            _logger = logger;
            _nutrientService = nutrientService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _nutrientService.GetAllAsync();

            var nutrients = new NutrientListViewModel
            {
                Nutrients = result.Data,
                Message = result.Message
            };
            if (result.Success)
            {
                return View(nutrients);
            }
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
