using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.Business.Constants;
using TouristProject.DataAccess.Abstract;
using TouristProject.DataAccess.Concrete.EntityFramework.Repositories;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.Categories;
using TouristProject.Entities.DTOs.Nutrients;
using TouristProject.Shared.Utilities.Result.Abstract;
using TouristProject.Shared.Utilities.Result.Concrete;

namespace TouristProject.Business.Concrete
{
    public class NutrientManager : INutrientService
    {

        #region Injection

        INutrientRepository _nutrientRepository;
        IMapper _mapper;

        public NutrientManager(INutrientRepository nutrientRepository, IMapper mapper)
        {
            _nutrientRepository = nutrientRepository;
            _mapper = mapper;
        }

        #endregion


        public async Task<IResult> AddAsync(NutrientAddDto nutrientAddDto)
        {
            var nutient = _mapper.Map<Nutrient>(nutrientAddDto);
            await _nutrientRepository.AddAsync(nutient);
            await _nutrientRepository.SaveAsync();
            return new SuccessResult(Messages.NutrientAdded);
        }

        public async Task<IResult> DeleteAsync(int nutrientId)
        {
            var nutrient = await _nutrientRepository.GetAsync(n => n.Id == nutrientId);
            if (nutrient != null)
            {
                var deletedNutrient = await _nutrientRepository.DeleteAsync(nutrient);
                await _nutrientRepository.SaveAsync();
                return new SuccessResult(Messages.NutrientDeleted);
            }
            else
            {
                return new ErrorResult(Messages.NutrientNotFound);
            }
        }

        public async Task<IDataResult<NutrientListDto>> GetAllAsync()
        {
            var nutrients = await _nutrientRepository.GetAllAsync();
            if (nutrients != null)
            {
                return new SuccessDataResult<NutrientListDto>(new NutrientListDto { Nutrients = nutrients }, Messages.NutrientListed);
            }
            else
            {
                return new ErrorDataResult<NutrientListDto>(new NutrientListDto { Nutrients = null }, Messages.NutrientNotFound);
            }
        }

        public async Task<IDataResult<NutrientDto>> GetByIdAsync(int nutrientId)
        {
            var nutrient = await _nutrientRepository.GetAsync(n => n.Id == nutrientId);
            if (nutrient != null)
            {
                return new SuccessDataResult<NutrientDto>(new NutrientDto { Nutrient = nutrient }, Messages.NutrientGeted);
            }
            else
            {
                return new ErrorDataResult<NutrientDto>(Messages.NutrientNotFound);
            }
        }

        public async Task<IResult> UpdateAsync(NutrientUpdateDto nutrientUpdateDto)
        {
            var oldNutrient = await _nutrientRepository.GetAsync(n => n.Id == nutrientUpdateDto.Id);
            var nutrient = _mapper.Map<NutrientUpdateDto, Nutrient>(nutrientUpdateDto, oldNutrient);
            var updatedNutrient = await _nutrientRepository.UpdateAsync(nutrient);
            await _nutrientRepository.SaveAsync();

            return new SuccessResult(Messages.NutrientUpdated);
        }
    }
}
