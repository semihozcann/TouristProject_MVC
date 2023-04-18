using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.Entities.DTOs.NutrientImages;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Models.NutrientImages;

namespace TouristProject.WebMVC.Areas.Admins.Controllers
{
    public class NutrientImagesController : BaseController
    {
        private readonly INutrientImageService _nutrientImageService;
        private readonly INutrientService _nutrientService;
        private readonly IFileHelper _fileHelper;
        public NutrientImagesController(IUserAccessor userAccessor, INutrientImageService nutrientImageService, INutrientService nutrientService, IFileHelper fileHelper) : base(userAccessor)
        {
            _nutrientImageService = nutrientImageService;
            _nutrientService = nutrientService;
            _fileHelper = fileHelper;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> GetAllNutrientImages()
        {
            var nutrient = await _nutrientService.GetAllAsync();
            var result = await _nutrientImageService.GetAllAsync();

            var nutrientImages = new NutrientImageListViewModel
            {
                NutrientImages = result.Data,
                Message = result.Message
            };

            if (result.Success)
            {
                return View(nutrientImages);

            }
            return View();
        }

        public async Task<IActionResult> Add()
        {
            var model = new NutrientImageAddViewModel();

            var nutrient = await _nutrientService.GetAllAsync();

            List<SelectListItem> nutrients = (from x in nutrient.Data.Nutrients.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();
            model.NutrientsForDr = nutrients;
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(NutrientImageAddViewModel nutrientImageAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var nutrientImage = new NutrientImageAddDto
                {
                    NutrientId = nutrientImageAddViewModel.NutrientId
                };

                var fileName = nutrientImageAddViewModel.ImageUrl;
                var imageFile = _fileHelper.UploadFile(fileName);
                nutrientImage.ImageUrl = imageFile;

                var result = await _nutrientImageService.AddAsync(nutrientImage);

                if (result.Success)
                {
                    return RedirectToAction("GetAllNutrientImages");
                }
                return View(nutrientImage);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _nutrientImageService.DeleteAsync(id);
            if (result.Success)
            {
                return RedirectToAction("GetAllNutrientImages");
            }
            return View();
        }




    }
}
