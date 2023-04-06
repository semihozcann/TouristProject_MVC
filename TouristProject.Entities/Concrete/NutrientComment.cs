using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.Concrete
{
    public class NutrientComment : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int NutrientId { get; set; }
        public string Comment { get; set; }
        public double Point { get; set; }


        //Navigation Property
        public virtual User User { get; set; }
        public virtual Nutrient Nutrient { get; set; }
    }
}
