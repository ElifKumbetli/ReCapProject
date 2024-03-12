using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().MinimumLength(2).WithMessage("Car Name min 2 olmalıdır.");
            RuleFor(c => c.DailyPrice).GreaterThan(0);
        }
    }
}
