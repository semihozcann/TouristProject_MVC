using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.Entities.DTOs.Categories;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Models.Categories;

namespace TouristProject.WebMVC.Areas.Admins.Controllers
{

    public class CategoriesController : BaseController
    {

        private readonly ICategoryService _categoryService;

        public CategoriesController(IUserAccessor userAccessor, ICategoryService categoryService) : base(userAccessor)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddViewModel categoryAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var category = new CategoryAddDto()
                {
                    Name = categoryAddViewModel.Name
                };
                var result = await _categoryService.AddAsync(category);
                categoryAddViewModel.Message = result.Message;
                if (result.Success)
                {
                    ViewBag.CategoryResultMessage = result.Message;
                    return RedirectToAction("GetAllCategories");
                }
                ViewBag.CategoryResultMessage = result.Message;
                return View(categoryAddViewModel);
            }
            return View(categoryAddViewModel);
        }



        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllAsync();

            var categories = new CategoryListViewModel
            {
                Category = result.Data,
                Message = result.Message
            };
            if (result.Success)
            {
                return View(categories);
            }
            return View();
        }


        public async Task<IActionResult> Update(int Id)
        {

            var category = await _categoryService.GetByIdAsync(Id);

            var oldCategory = new CategoryUpdateViewModel
            {
                Id = category.Data.Category.Id,
                Name = category.Data.Category.Name,
                Message = category.Message
            };

            return View(oldCategory);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateViewModel categoryUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var updatedCategory = new CategoryUpdateDto
                {
                    Id = categoryUpdateViewModel.Id,
                    Name = categoryUpdateViewModel.Name
                };
                var result = await _categoryService.UpdateAsync(updatedCategory);

                categoryUpdateViewModel.Message = result.Message;
                if (result.Success)
                {
                    ViewBag.CategoryResultMessage = result.Message;
                    return RedirectToAction("GetAllCategories");
                }
                ViewBag.CategoryResultMessage = result.Message;
                return View(result.Message);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {

            var result = await _categoryService.DeleteAsync(Id);
            if (result.Success)
            {
                return RedirectToAction("GetAllCategories");
            }
            else
            {
                ViewBag.CategoryResultMessage = result.Message;
                return View(result.Message);
            }
        }

    }
}
