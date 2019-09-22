using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;
using FluentValidation;

namespace Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation
{
    public class PaymentViewModelValidator : AbstractValidator<PaymentViewModel>
    {
        public PaymentViewModelValidator()
        {
            RuleFor(m => m.Payment.CreditCardNo).NotEmpty().Matches(@"^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$");
            RuleFor(m => m.Payment.CreditCardOwnerName).NotEmpty().Matches(@"^[a-zA-ZöçşığüÖÇŞİĞÜ,]+(\s{0,1}[a-zA-ZöçşığüÖÇŞİĞÜ, ])*$");
            RuleFor(m => m.Payment.CreditCardExpiryDate).NotEmpty().Matches(@"^(0[1-9]|1[0-2])\/?([0-9]{4}|[0-9]{2})$");
            RuleFor(m => m.Payment.CreditCardCVC).NotEmpty().Matches(@"^[0-9]{3,4}$");
            
        }
    }
}
