using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.DataAccess.Abstract;
using TouristProject.Entities.Concrete;
using TouristProject.Shared.DataAccess.Concrete;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : BaseEntityRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
