using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.PlaceToVisits;

namespace TouristProject.DataAccess.AutoMapper
{
    public class PlaceToVisitProfile : Profile
    {
        public PlaceToVisitProfile()
        {
            CreateMap<PlaceToVisitAddDto, PlaceToVisit>();
            CreateMap<PlaceToVisitUpdateDto, PlaceToVisit>();
            CreateMap<PlaceToVisit, PlaceToVisitUpdateDto>();
        }
    }
}
