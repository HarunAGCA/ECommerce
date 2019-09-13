using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;
using Agca.ECommerce.Entities.Concrete;
using FluentValidation;

namespace Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailsViewModelValidator : AbstractValidator<ShippingDetailsViewModel>
    {
        public ShippingDetailsViewModelValidator()
        {
            RuleFor(m => m.ShippingDetails.CustomerFirstName).NotEmpty().MaximumLength(20);
            RuleFor(m => m.ShippingDetails.CustomerLastName).NotEmpty().MaximumLength(20);
            RuleFor(m => m.ShippingDetails.CustomerTurkishId).NotEmpty().Length(11);
            RuleFor(m => m.ShippingDetails.PhoneNumber).NotEmpty();
            RuleFor(m => m.ShippingDetails.EMail).NotEmpty().EmailAddress();
            RuleFor(m => m.ShippingDetails.ShippingAdress).NotEmpty();

        }
    }
}
