using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserDetailValidator:AbstractValidator<UserDetail>
    {
        public UserDetailValidator()
        {
            RuleFor(x => x.IdentityNumber).Length(11);
        }
    }
}
