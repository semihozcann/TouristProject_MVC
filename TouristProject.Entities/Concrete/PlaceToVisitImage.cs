using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.Concrete
{
    public class PlaceToVisitImage : BaseEntity, IEntity
    {
        public string ImageUrl { get; set; }
        public int PlaceToVisitId { get; set; }


        public PlaceToVisit PlaceToVisit { get; set; }
    }
}
