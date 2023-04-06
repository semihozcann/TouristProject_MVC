using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.PlaceToVisits
{
    public class PlaceToVisitDto : IDto
    {
        public PlaceToVisit PlaceToVisit { get; set; }
    }
}
