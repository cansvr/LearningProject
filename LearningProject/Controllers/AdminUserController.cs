﻿using BusinessLayer.Concrete;
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
    public class AdminUserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        public ActionResult Index()
        {
            var userValues = um.GetList();
            return View(userValues);
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

        public ActionResult DeleteUser(int id)
        {
            var userValue = um.GetByID(id);
            um.UserDelete(userValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditUser(int id)
        {
            var userValue = um.GetByID(id);
            return View(userValue);
        }

        [HttpPost]
        public ActionResult EditUser(User p)
        {
            um.UserUpdate(p);
            return RedirectToAction("Index");
        }
    }
}