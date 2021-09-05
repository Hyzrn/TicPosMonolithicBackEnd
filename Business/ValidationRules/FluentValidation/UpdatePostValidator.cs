using Entities.Concrete;
using Entities.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UpdatePostValidator:AbstractValidator<UpdatePostDto>
    {
        public UpdatePostValidator()
        {
            RuleFor(x => x.ActivityId).NotNull();
            RuleFor(x => x.Description).NotNull();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Description).Length(2,1000);
            RuleFor(x => x.Code).NotNull();
            RuleFor(x => x.Code).NotEmpty();
            RuleFor(x => x.Code).MaximumLength(50);
            RuleFor(x => x.Date).NotNull();
        }
    }
}
