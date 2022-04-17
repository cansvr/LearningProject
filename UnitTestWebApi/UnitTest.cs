using EntityLayer.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;

namespace UnitTestWebApi
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GetUser()
        {
            IList<User> userList = new List<User>();
            userList = new UserController().GetUserList();
            Assert.IsNotNull(userList);
        }

        [TestMethod]
        public void AddUser()
        {
            var result = "";
            User user = new User();
            user = new User() { USER_NAME = "Can", USER_SURNAME = "Sever", USER_MAIL = "can.sever@bilgiyon.com.tr" };
            result = new UserController().AddUser(user);
            Assert.AreEqual(user.USER_NAME +" Kullanıcısı için Ekleme Başarılı!", result);
        }

        [TestMethod]
        public void UpdateUser()
        {
            string result = "";
            User user = new User();
            user = new User() { USER_CODE = 1, USER_NAME = "Can", USER_SURNAME = "Sever", USER_MAIL = "can.sever@bilgiyon.com.tr" };
            result = new UserController().UpdateUser(user);
            Assert.AreEqual(user.USER_NAME + " Kullanıcısı için Güncelleme Başarılı!", result);
        }
    }
}
