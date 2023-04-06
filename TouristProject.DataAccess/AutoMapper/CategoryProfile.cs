using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.Categories;

namespace TouristProject.DataAccess.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<Category, CategoryUpdateDto>();

            CreateMap<Category, CategoryListDto>();
            CreateMap<CategoryListDto, Category>();
        }
    }
}
