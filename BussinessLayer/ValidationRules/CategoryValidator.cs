using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace BussinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz!"); 
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklmayı Boş Geçemezsiniz!"); 
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karekter Girişi Yapınız!"); 
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 Karakterden Fazla Karakter Girişi Yapmayınız!"); 
        
        }

    }
}
