using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.NutrientImages
{
    public class NutrientImageAddDto : IDto
    {
        public string ImageUrl { get; set; }
        public int NutrientId { get; set; }
    }
}
