using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        UserManager um = new UserManager(new EfUserDal());

        [HttpGet]
        [Route("User/GetUserList")]
        public IList<User> GetUserList()
        {
            IList<User> userList = new List<User>();
            try
            {
                userList = um.GetList();
            }
            catch (Exception ex)
            {
                return null;
            }
            return userList;
        }

        [HttpPost]
        [Route("User/AddUser")]
        public string AddUser(User p)
        {
            try
            {
                UserValidator userValidator = new UserValidator();
                ValidationResult results = userValidator.Validate(p);

                if (results.IsValid)
                {
                    um.UserAdd(p);
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                    return p.USER_NAME + " Kullanıcısı için Ekleme Başarısız! Hata Mesajları: " + results.ToString().Replace("\r\n", " - ");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return p.USER_NAME + " Kullanıcısı için Ekleme Başarılı!";
        }

        [HttpPost]
        [Route("User/UpdateUser")]
        public string UpdateUser(User p)
        {
            try
            {
                UserValidator userValidator = new UserValidator();
                ValidationResult results = userValidator.Validate(p);
                User user = new User();
                if (results.IsValid)
                {
                    if (p.USER_CODE == 0)
                    {
                        return "Kullanıcı Kodu Girilmelidir!";
                    }

                    user = um.GetByID(p.USER_CODE);
                    if (user == null)
                    {
                        return p.USER_NAME + " Kullanıcısı Bulunamadı!";
                    }

                    user.USER_NAME = p.USER_NAME;
                    user.USER_SURNAME= p.USER_SURNAME;
                    user.USER_MAIL = p.USER_MAIL;

                    um.UserUpdate(user);
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                    return p.USER_NAME + " Kullanıcısı için Güncelleme Başarısız! Hata Mesajları: " + results.ToString().Replace("\r\n", " - ");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return p.USER_NAME + " Kullanıcısı için Güncelleme Başarılı!";
        }
    }
}
