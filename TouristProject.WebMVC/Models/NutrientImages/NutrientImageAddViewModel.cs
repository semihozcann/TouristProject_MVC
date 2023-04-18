using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TouristProject.WebMVC.Models.NutrientImages
{
    public class NutrientImageAddViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Bir besin çeşidi seçmelisiniz")]
        public int NutrientId { get; set; }
        public IFormFile ImageUrl { get; set; }

        public List<SelectListItem> NutrientsForDr { get; set; }
    }
}
