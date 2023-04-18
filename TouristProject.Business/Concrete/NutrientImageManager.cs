using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.Business.Constants;
using TouristProject.DataAccess.Abstract;
using TouristProject.Entities.Concrete;
using TouristProject.Entities.DTOs.NutrientImages;
using TouristProject.Shared.Utilities.Result.Abstract;
using TouristProject.Shared.Utilities.Result.Concrete;

namespace TouristProject.Business.Concrete
{
    public class NutrientImageManager : INutrientImageService
    {

        #region Injection

        private readonly INutrientImageRepository _nutrientImageRepository;
        private readonly IMapper _mapper;

        public NutrientImageManager(INutrientImageRepository nutrientImageRepository, IMapper mapper)
        {
            _nutrientImageRepository = nutrientImageRepository;
            _mapper = mapper;
        }

        #endregion


        public async Task<IResult> AddAsync(NutrientImageAddDto nutrientImageAddDto)
        {
            var nutrientImage = _mapper.Map<NutrientImage>(nutrientImageAddDto);
            await _nutrientImageRepository.AddAsync(nutrientImage);
            await _nutrientImageRepository.SaveAsync();
            return new SuccessResult(Messages.NutrientImageAdded);
        }

        public async Task<IResult> DeleteAsync(int nutrientImageId)
        {
            var nutrientImage = await _nutrientImageRepository.GetAsync(n => n.Id == nutrientImageId);
            if (nutrientImage != null)
            {
                var deletedNutrientImage = await _nutrientImageRepository.DeleteAsync(nutrientImage);
                await _nutrientImageRepository.SaveAsync();
                return new SuccessResult(Messages.NutrientImageDeleted);
            }
            else
            {
                return new ErrorResult(Messages.NutrientImageNotFound);
            }
        }

        public async Task<IDataResult<NutrientImageListDto>> GetAllAsync()
        {
            var nutrientImages = await _nutrientImageRepository.GetAllAsync();
            if (nutrientImages != null)
            {
                return new SuccessDataResult<NutrientImageListDto>(new NutrientImageListDto {NutrientImages = nutrientImages}, Messages.NutrientImageListed);
            }
            else
            {
                return new ErrorDataResult<NutrientImageListDto>(new NutrientImageListDto { NutrientImages = null}, Messages.NutrientImageNotFound);
            }
        }

        public async Task<IDataResult<NutrientImageDto>> GetByIdAsync(int nutrientImageId)
        {
            var nutrientImage = await _nutrientImageRepository.GetAsync(n => n.Id == nutrientImageId);
            if (nutrientImage != null)
            {
                return new SuccessDataResult<NutrientImageDto>(new NutrientImageDto { NutrientImage = nutrientImage }, Messages.NutrientImageGeted);
            }
            else
            {
                return new ErrorDataResult<NutrientImageDto>(new NutrientImageDto { NutrientImage = null}, Messages.NutrientImageNotFound);
            }
        }

        public async Task<IResult> UpdateAsync(NutrientImageUpdateDto nutrientImageUpdateDto)
        {
            var oldNutrientImage = await _nutrientImageRepository.GetAsync(n => n.Id == nutrientImageUpdateDto.Id);
            var nutrientImage = _mapper.Map<NutrientImageUpdateDto, NutrientImage>(nutrientImageUpdateDto, oldNutrientImage);
            var updatedNutrientImage = await _nutrientImageRepository.UpdateAsync(nutrientImage);
            await _nutrientImageRepository.SaveAsync();
            return new SuccessResult(Messages.NutrientImageUpdated);

        }
    }
}
