using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class RoleValidator:AbstractValidator<UserRoles>
    {
        public RoleValidator()
        {
            RuleFor(x => x.ROLE_NAME).NotEmpty().WithMessage("Rol adını boş geçemezsiniz!");
        }
    }
}
