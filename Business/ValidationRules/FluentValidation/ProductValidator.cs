using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty(); // WithMessage("Ürün adı boş geçilemez!");
            RuleFor(x => x.ProductName).Length(2, 30);
            RuleFor(x => x.UnitPrice).NotEmpty();
            RuleFor(x => x.UnitPrice).GreaterThanOrEqualTo(1);
            //RuleFor(x => x.UnitPrice).GreaterThanOrEqualTo(10).When(x => x.CategoryId == 1);
            //RuleFor(x => x.ProductName).Must(StarsWithA);
        }

        private bool StarsWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
