using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.Nutrients;

namespace TouristProject.DataAccess.AutoMapper
{
    public class NutrientProfile : Profile
    {
        public NutrientProfile()
        {
            CreateMap<NutrientAddDto, Nutrient>();
            CreateMap<NutrientUpdateDto, Nutrient>();
            CreateMap<Nutrient, NutrientUpdateDto>();
        }
    }
}
