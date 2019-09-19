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
            RuleFor(m => m.Shipment.ReceiverFirstName).NotEmpty().MaximumLength(20);
            RuleFor(m => m.Shipment.ReceiverLastName).NotEmpty().MaximumLength(20);
            RuleFor(m => m.Shipment.ReceiverTurkishIdNo).NotEmpty().Length(11).Matches(@"^[0-9]{11}$");
            RuleFor(m => m.Shipment.ReceiverPhoneNumber).NotEmpty().Matches(@"\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})");
            RuleFor(m => m.Shipment.ReceiverEMail).NotEmpty().EmailAddress();
            RuleFor(m => m.Shipment.ReceiverAddress).NotEmpty();

        }
    }
}
