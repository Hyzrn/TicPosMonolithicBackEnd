using Core.Entities.Concrete;
using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserForLoginValidator : AbstractValidator<UserForLoginDto>
    {
        public UserForLoginValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Email).MaximumLength(250);
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}
