using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.Entities.DTOs.Categories;
using TouristProject.Entities.DTOs.Nutrients;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Models.Nutrients;

namespace TouristProject.WebMVC.Areas.Admins.Controllers
{
    public class NutrientsController : BaseController
    {
        private readonly INutrientService _nutrientService;
        private readonly INutrientImageService _nutrientImageService;
        private readonly ICategoryService _categoryService;
        private readonly IFileHelper _fileHelper;


        public NutrientsController(IUserAccessor userAccessor, INutrientService nutrientService, ICategoryService categoryService, IFileHelper fileHelper, INutrientImageService nutrientImageService) : base(userAccessor)
        {
            _nutrientService = nutrientService;
            _categoryService = categoryService;
            _fileHelper = fileHelper;
            _nutrientImageService = nutrientImageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var model = new NutrientAddViewModel();
            var category = _categoryService.GetCategories();

            List<SelectListItem> values = (from x in category.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();
            model.CategoriesForDr = values;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(NutrientAddViewModel nutrientAddViewModel)
        {
            if (ModelState.IsValid)
            {

                var nutrient = new NutrientAddDto()
                {
                    CategoryId = nutrientAddViewModel.CategoryId,
                    Name = nutrientAddViewModel.Name,
                    Description = nutrientAddViewModel.Description,
                    SmallDescription = nutrientAddViewModel.SmallDescription,
                    Ingredients = nutrientAddViewModel.Ingredients
                };

                var fileName = nutrientAddViewModel.ImageUrl;
                var imageFile = _fileHelper.UploadFile(fileName);
                nutrient.ImageUrl = imageFile;

                var result = await _nutrientService.AddAsync(nutrient);
                nutrientAddViewModel.Message = result.Message;
                if (result.Success)
                {
                    return RedirectToAction("GetAllNutrients");
                }
                ViewBag.NutrientResultMessage = result.Message;
                return View(nutrientAddViewModel);
            }
            return View(nutrientAddViewModel);
        }


        public async Task<IActionResult> GetAllNutrients()
        {
            var category = await _categoryService.GetAllAsync();
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

        public async Task<IActionResult> Update(int Id)
        {

            var result = await _nutrientService.GetByIdAsync(Id);


            var nutrient = new NutrientUpdateViewModel 
            {
                Id = result.Data.Nutrient.Id,
                Name = result.Data.Nutrient.Name,
                Description = result.Data.Nutrient.Description,
                SmallDescription = result.Data.Nutrient.SmallDescription,
                Ingredients = result.Data.Nutrient.Ingredients,
                Message = result.Message
            };

            var category = _categoryService.GetCategories();

            List<SelectListItem> values = (from x in category.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.Id.ToString()
                                           }).ToList();
            nutrient.CategoriesForDr = values;

            return View(nutrient);
        }

        [HttpPost]
        public async Task<IActionResult> Update(NutrientUpdateViewModel nutrientUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var nutrient = new NutrientUpdateDto
                {
                    Id = nutrientUpdateViewModel.Id,
                    CategoryId = nutrientUpdateViewModel.CategoryId,
                    Name = nutrientUpdateViewModel.Name,
                    Description = nutrientUpdateViewModel.Description,
                    SmallDescription = nutrientUpdateViewModel.SmallDescription,
                    Ingredients = nutrientUpdateViewModel.Ingredients
                };
                var result = await _nutrientService.UpdateAsync(nutrient);
                nutrientUpdateViewModel.Message = result.Message;
                if (result.Success)
                {
                    return RedirectToAction("GetAllNutrients");
                }
                return View();
            }
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _nutrientService.DeleteAsync(Id);
            ViewBag.NutrientResultMessage = result.Message;
            if (result.Success)
            {
                return RedirectToAction("GetAllNutrients");
            }
            else
            {
                return View(result);
            }
        }




    }
}
