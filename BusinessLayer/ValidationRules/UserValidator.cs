using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.USER_NAME).NotEmpty().WithMessage("Kullanıcı Adını boş geçemezsiniz!");
            RuleFor(x => x.USER_SURNAME).NotEmpty().WithMessage("Kullanıcı Soyadını boş geçemezsiniz!");
            RuleFor(x => x.USER_MAIL).NotEmpty().WithMessage("Kullanıcı Mail adresini boş geçemezsiniz!");
        }
    }
}
