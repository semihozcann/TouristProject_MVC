using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Shared.Entities;

namespace TouristProject.Entities.DTOs.Categories
{
    public class CategoryUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
