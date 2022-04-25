using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRoleService
    {
        List<UserRoles> GetList();
        void UserRoleAdd(UserRoles user);
        UserRoles GetByID(int id);
        void UserRoleDelete(UserRoles user);
        void UserRoleUpdate(UserRoles user);
    }
}
