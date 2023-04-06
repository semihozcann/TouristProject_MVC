using AutoMapper;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.Categories;
using TouristProject.WebMVC.Models.Categories;

namespace TouristProject.WebMVC.AutoMapper
{
    public class CategoryViewModelProfile : Profile
    {
        public CategoryViewModelProfile()
        {
            CreateMap<CategoryListViewModel, CategoryListDto>();
            CreateMap<CategoryListDto, CategoryListViewModel>();
        }
    }
}
