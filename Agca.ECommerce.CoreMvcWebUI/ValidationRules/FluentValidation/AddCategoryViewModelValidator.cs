using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;
using FluentValidation;

namespace Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation
{
    public class AddCategoryViewModelValidator:AbstractValidator<AddCategoryViewModel>
    {
        public AddCategoryViewModelValidator()
        {
            RuleFor(c => c.Category.Name).NotEmpty().MinimumLength(2);
        }
    }
}
