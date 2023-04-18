using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.DTOs.NutrientImages;
using TouristProject.Entities.DTOs.Nutrients;
using TouristProject.Shared.Utilities.Result.Abstract;

namespace TouristProject.Business.Abstract
{
    public interface INutrientImageService
    {
        Task<IDataResult<NutrientImageDto>> GetByIdAsync(int nutrientImageId);
        Task<IDataResult<NutrientImageListDto>> GetAllAsync();
        Task<IResult> AddAsync(NutrientImageAddDto nutrientImageAddDto);
        Task<IResult> UpdateAsync(NutrientImageUpdateDto nutrientImageUpdateDto);
        Task<IResult> DeleteAsync(int nutrientImageId);
    }
}
