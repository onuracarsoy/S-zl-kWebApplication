using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class MessageValidator: AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini Boş Geçemezsiniz!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz!");
            RuleFor(x => x.MessageContent).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Girişi Yapınız!");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Girişi Yapınız!");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen Fazla 100 Karakter Girişi Yapınız!");

        }
        
    }
}
