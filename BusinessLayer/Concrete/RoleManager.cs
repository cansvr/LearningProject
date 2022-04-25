using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public UserRoles GetByID(int id)
        {
            return _roleDal.Get(x => x.ROLE_CODE == id);
        }

        public List<UserRoles> GetList()
        {
            return _roleDal.List();
        }

        public void UserRoleAdd(UserRoles role)
        {
            _roleDal.Insert(role);
        }

        public void UserRoleDelete(UserRoles role)
        {
            _roleDal.Delete(role);
        }

        public void UserRoleUpdate(UserRoles role)
        {
            _roleDal.Update(role);
        }
    }
}
