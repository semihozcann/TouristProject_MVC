using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.Concrete
{
    public class NutrientImage : BaseEntity, IEntity
    {
        public string ImageUrl { get; set; }
        public int NutrientId { get; set; }


        public Nutrient Nutrient { get; set; }
    }
}
