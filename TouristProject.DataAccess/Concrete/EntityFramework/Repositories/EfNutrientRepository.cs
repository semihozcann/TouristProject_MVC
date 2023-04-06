using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.DataAccess.Abstract;
using TouristProject.DataAccess.Concrete.EntityFramework.Context;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.Nutrients;
using TouristProject.Shared.DataAccess.Concrete;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfNutrientRepository : BaseEntityRepository<Nutrient>, INutrientRepository
    {
        public EfNutrientRepository(DbContext context) : base(context)
        {
        }
    }
}
