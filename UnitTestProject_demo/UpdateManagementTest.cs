using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagementLibrary;
using UserManagementOperation;

namespace UnitTestProject_demo
{
    
    [TestClass]
    public class UpdateManagementTest
    {
        [TestMethod]
        public void TestUpdateUser()
        {
            User user = new User();
            user.Id = 423;
            user.FirstName = "Sachin";
            user.LastName = "Tendulkar";
            user.EmailId = "st@gmail.com";
            user.PhoneNumber = "1001001003";

            //userUpdateOperation userUpdate = new userUpdateOperation();
            //userUpdate.UpdateUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);

            IuserUpdateOperation service1 = ServiceFactory.getService1();
            service1.UpdateUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);
            

            //Assert.IsTrue(collectId > 0);



        }
    }
}
