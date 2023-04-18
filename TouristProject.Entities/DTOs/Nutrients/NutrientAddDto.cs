using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.Nutrients
{
    public class NutrientAddDto : IDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public string Ingredients { get; set; }
        public string ImageUrl { get; set; }
    }
}
