using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.Categories;
using TouristProject.Shared.Utilities.Result.Abstract;

namespace TouristProject.Business.Abstract
{
    public interface ICategoryService
    {

        Task<IDataResult<CategoryDto>> GetByIdAsync(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAllAsync();
        Task<IResult> AddAsync(CategoryAddDto categoryAddDto);
        Task<IResult> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<IResult> DeleteAsync(int categoryId);
        Task<IDataResult<CategoryUpdateDto>> GetCategoryUpdateDtoAsync(int categoryId);

        List<Category> GetCategories();

    }
}
