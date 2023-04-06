using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.DTOs.Categories;
using TouristProject.Entities.DTOs.Nutrients;
using TouristProject.Shared.Utilities.Result.Abstract;

namespace TouristProject.Business.Abstract
{
    public interface INutrientService
    {

        Task<IDataResult<NutrientDto>> GetByIdAsync(int nutrientId);
        Task<IDataResult<NutrientListDto>> GetAllAsync();
        Task<IResult> AddAsync(NutrientAddDto nutrientAddDto);
        Task<IResult> UpdateAsync(NutrientUpdateDto nutrientUpdateDto);
        Task<IResult> DeleteAsync(int nutrientId);

    }
}
