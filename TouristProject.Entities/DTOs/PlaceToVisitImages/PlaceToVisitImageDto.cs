using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.PlaceToVisitImages
{
    public class PlaceToVisitImageDto : IDto
    {
        public PlaceToVisitImage PlaceToVisitImage { get; set; }
    }
}
