using System;
using System.Collections.Generic;
using TouristProject.Entities.DTOs.Categories;

namespace TouristProject.WebMVC.Models.Categories
{
    public class CategoryListViewModel : BaseViewModel
    {
        public CategoryListDto Category { get; set; }
    }
}
