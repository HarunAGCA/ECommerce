using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agca.ECommerce.CoreMvcWebUI.Models;
using FluentValidation;

namespace Agca.ECommerce.CoreMvcWebUI.ValidationRules.FluentValidation
{
    public class RegisterViewModelValidator:AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(p => p.UserName).NotEmpty().MinimumLength(5);
            RuleFor(p => p.EMail).NotEmpty().EmailAddress();
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.ConfirmPassword).NotEmpty();
        }
    }
}
