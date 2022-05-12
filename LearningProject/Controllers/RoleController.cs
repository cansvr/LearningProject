using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningProject.Controllers
{
    public class RoleController : Controller
    {
        RoleManager rm = new RoleManager(new EfRoleDal());
        UserManager um = new UserManager(new EfUserDal());
        public ActionResult Index()
        {
            var roleValues = rm.GetList();
            return View(roleValues);
        }

        [HttpGet]
        public ActionResult AddRole()
        {
            List<SelectListItem> valueRole = (from x in um.GetList()
                                              select new SelectListItem
                                              { 
                                                  Text=x.USER_NAME,
                                                  Value=x.USER_CODE.ToString()
                                              }
                                              ).ToList();
            ViewBag.vlc = valueRole;
            return View();
        }

        [HttpPost]
        public ActionResult AddRole(UserRoles p)
        {
            RoleValidator userValidator = new RoleValidator();
            ValidationResult results = userValidator.Validate(p);
            if (results.IsValid)
            {
                rm.UserRoleAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteRole(int id)
        {
            var roleValue = rm.GetByID(id);
            rm.UserRoleDelete(roleValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditRole(int id)
        {
            var roleValue = rm.GetByID(id);
            return View(roleValue);
        }

        [HttpPost]
        public ActionResult EditRole(UserRoles p)
        {
            rm.UserRoleUpdate(p);
            return RedirectToAction("Index");
        }
    }
}