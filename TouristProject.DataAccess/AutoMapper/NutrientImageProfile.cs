using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.NutrientImages;

namespace TouristProject.DataAccess.AutoMapper
{
    public class NutrientImageProfile : Profile
    {
        public NutrientImageProfile()
        {
            CreateMap<NutrientImageAddDto, NutrientImage>();
            CreateMap<NutrientImageUpdateDto, NutrientImage>();
            CreateMap<NutrientImage, NutrientImageUpdateDto>();

        }
    }
}
