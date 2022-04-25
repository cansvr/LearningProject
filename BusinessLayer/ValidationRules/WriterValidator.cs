using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WRITER_NAME).NotEmpty().WithMessage("Yazar Adını boş geçemezsiniz!");
            RuleFor(x => x.WRITER_SURNAME).NotEmpty().WithMessage("Yazar Soyadını boş geçemezsiniz!");
            RuleFor(x => x.WRITER_MAIL).NotEmpty().WithMessage("Yazar Mail adresini boş geçemezsiniz!");
        }
    }
}
