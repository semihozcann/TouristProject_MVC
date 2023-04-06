using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.PlaceToVisits
{
    public class PlaceToVisitUpdateDto : IDto
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public string History { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string CloseDay { get; set; }
    }
}
