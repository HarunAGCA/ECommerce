using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;
using FluentValidation;

namespace Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation
{
    public class UpdateProductViewModelValidator:AbstractValidator<UpdateProductViewModel>
    {
        public UpdateProductViewModelValidator()
        {
            RuleFor(m => m.Product.Name).NotEmpty();
            RuleFor(m => m.Product.UnitPrice).NotEmpty().ExclusiveBetween(0, Decimal.MaxValue);
            RuleFor(m => m.Product.UnitsInStock).NotNull().InclusiveBetween(0, Int32.MaxValue);
            RuleFor(m => m.Product.CategoryId).NotEmpty().ExclusiveBetween(0, Int32.MaxValue);
        }
    }
}
