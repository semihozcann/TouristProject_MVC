using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Business.Constants;
using TouristProject.Entities.DTOs.Categories;

namespace TouristProject.Business.ValidationRules.FluentValidation.Categories
{
    public abstract class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage(Messages.CategoryNameNotEmpty);
            RuleFor(c => c.Name).MaximumLength(50).WithMessage(Messages.CategoryNameMaxLength);
        }
    }
}
