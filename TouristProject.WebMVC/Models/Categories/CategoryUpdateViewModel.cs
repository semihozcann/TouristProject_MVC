using System.ComponentModel.DataAnnotations;

namespace TouristProject.WebMVC.Models.Categories
{
    public class CategoryUpdateViewModel : BaseViewModel
    {

        public int Id { get; set; }

        [MaxLength(ErrorMessage = "Kategori adı en fazla 50 karakter olabilir.")]
        [Required(ErrorMessage = "Kategori ismi boş olmaz")]
        public string Name { get; set; }

    }
}
