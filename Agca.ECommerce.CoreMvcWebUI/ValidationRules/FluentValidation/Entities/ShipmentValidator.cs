using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.Entities.Concrete;
using FluentValidation;

namespace Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation.Entities
{
    public class ShipmentValidator:AbstractValidator<Shipment>
    {
        public ShipmentValidator()
        {
            RuleFor(s => s.ReceiverTurkishIdNo).Matches(@"^[1-9]{1}[0-9]{10}$");
            RuleFor(s => s.ReceiverFirstName).MaximumLength(30).Matches(@"^[a-zA-ZöçşığüÖÇŞİĞÜ,]+(\s{0,1}[a-zA-ZöçşığüÖÇŞİĞÜ, ])*$");
            RuleFor(s => s.ReceiverLastName).MaximumLength(20).Matches(@"^[a-zA-ZöçşığüÖÇŞİĞÜ,]+(\s{0,1}[a-zA-ZöçşığüÖÇŞİĞÜ, ])*$");
            RuleFor(s => s.ReceiverPhoneNumber).Matches(@"\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})");
            RuleFor(s => s.ReceiverEMail).EmailAddress();
            RuleFor(s => s.ReceiverAddress).NotEmpty();
        }
    }
}
