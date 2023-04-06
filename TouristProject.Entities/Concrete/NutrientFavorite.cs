using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.Concrete
{
    public class NutrientFavorite : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int NutrientId { get; set; }

        public virtual User User { get; set; }
        public virtual Nutrient Nutrient { get; set; }
    }
}
