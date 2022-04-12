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
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUserList()
        {
            var userList = um.GetList();
            return View(userList);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User p)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult results = userValidator.Validate(p);
            if (results.IsValid)
            {
                um.UserAdd(p);
                return RedirectToAction("GetUserList");
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
    }
}