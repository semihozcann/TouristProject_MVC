using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TouristProject.WebMVC.Models.Nutrients
{
    public class NutrientUpdateViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bir kategori seçmelisiniz")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Besin ismi boş olmaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş olmaz")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Kısa açıklama alanı boş olmaz")]
        public string SmallDescription { get; set; }

        [Required(ErrorMessage = "İçindekiler alanı boş olmaz")]
        public string Ingredients { get; set; }
        public IFormFile ImageUrl { get; set; }

        public List<SelectListItem> CategoriesForDr { get; set; }

    }
}
