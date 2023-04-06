using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.Categories
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }

    }
}
