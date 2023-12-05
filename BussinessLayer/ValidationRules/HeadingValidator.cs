using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        { 
        RuleFor(x => x.HeadingName).MaximumLength(20).WithMessage("Lütfen Fazla 20 Karakter Girişi Yapınız!");
    }
}
}
