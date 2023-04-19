using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Models.Nutrients;

namespace TouristProject.WebMVC.Areas.Users.Controllers
{
    public class NutrientsController : BaseController
    {
        private readonly INutrientService _nutrientService;
        private readonly ICategoryService _categoryService;
        private readonly INutrientImageService _nutrientImageService;

        public NutrientsController(IUserAccessor userAccessor, INutrientService nutrientService, ICategoryService categoryService, INutrientImageService nutrientImageService) : base(userAccessor)
        {
            _nutrientService = nutrientService;
            _categoryService = categoryService;
            _nutrientImageService = nutrientImageService;
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

        public async Task<IActionResult> NutrientDetails(int id)
        {
            var nutrientImages = await _nutrientImageService.GetAllAsync();
            var result = await _nutrientService.GetByIdAsync(id);

            var nutrient = new NutrientViewModel
            {
                Nutrient = result.Data,
                Message = result.Message
            };

            if (result.Success)
            {
                return View(nutrient);
            }
            return View();
        }

    }
}
