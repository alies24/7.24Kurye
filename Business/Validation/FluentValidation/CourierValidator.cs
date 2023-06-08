using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class CourierValidator:AbstractValidator<Courier>
    {
        public CourierValidator()
        {
            RuleFor(c => c.CourierName).NotEmpty();
            RuleFor(c => c.CourierSurname).NotEmpty();
            RuleFor(c => c.IdentityNumber).NotEmpty().MaximumLength(11).MinimumLength(11);
        }
    }
}
