using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.Categories
{
    public class CategoryDto : IDto
    {
        public Category Category { get; set; }
    }
}
