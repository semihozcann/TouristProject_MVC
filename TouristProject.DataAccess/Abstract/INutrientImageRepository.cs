using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Shared.DataAccess.Abstract;

namespace TouristProject.DataAccess.Abstract
{
    public interface INutrientImageRepository : IEntityRepository<NutrientImage>
    {
    }
}
