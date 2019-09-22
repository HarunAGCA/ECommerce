using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Entities.Concrete;
using FluentValidation;

namespace Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation.Entities
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().MinimumLength(3);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo(0);
            RuleFor(p => p.UnitPrice).GreaterThan(0);
        }
    }
}
