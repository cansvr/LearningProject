using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Controllers;

namespace UnitTest.WebApiTest.User
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void GetUser()
        {
            //new UserController().GetUserList();
        }

        [TestMethod]
        public void AddUser()
        {
            //new UserController().AddUser(new User
            //{
            //    USER_CODE = "1",
            //    USER_NAME = "CAN",
            //    USER_SURNAME = "SEVER",
            //    USER_MAIL = "MAIL@ADRES",
            //});
        }

        [TestMethod]
        public void UpdateUser()
        {
            //new UserController().UpdateUser(new User
            //{
            //    USER_CODE = "7",
            //    USER_NAME = "CAN",
            //    USER_SURNAME = "SEVER",
            //    USER_MAIL = "MAIL@ADRES",
            //});
        }
    }
}