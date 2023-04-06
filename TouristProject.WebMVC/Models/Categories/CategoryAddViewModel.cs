using System.ComponentModel.DataAnnotations;

namespace TouristProject.WebMVC.Models.Categories
{
    public class CategoryAddViewModel : BaseViewModel
    {
        [MaxLength(ErrorMessage ="Kategori adı en fazla 50 karakter olabilir.")]
        [Required(ErrorMessage ="Kategori ismi boş olmaz")]
        public string Name { get; set; }

    }
}
