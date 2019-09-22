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
            
            RuleFor(s => s.Shipment.ReceiverTurkishIdNo).Matches(@"^[1-9]{1}[0-9]{10}$");
            RuleFor(s => s.Shipment.ReceiverFirstName).MaximumLength(30);
            RuleFor(s => s.Shipment.ReceiverLastName).MaximumLength(20);
            RuleFor(s => s.Shipment.ReceiverPhoneNumber).Matches(@"\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})");
            RuleFor(s => s.Shipment.ReceiverEMail).EmailAddress();
            RuleFor(s => s.Shipment.ReceiverAddress).NotEmpty();

        }
    }
}
