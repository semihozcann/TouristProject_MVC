using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Models.Nutrients;

namespace TouristProject.WebMVC.Areas.Users.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly INutrientService _nutrientService;

        public DashboardController(IUserAccessor userAccessor, INutrientService nutrientService) : base(userAccessor)
        {
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
    }
}
