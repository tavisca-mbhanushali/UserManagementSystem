using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagementLibrary;
using UserManagementOperation;

namespace UnitTestProject_demo
{

    [TestClass]
    public class DeleteManagementTest
    {
        [TestMethod]
        public void TestUpdateUser()
        {
            User user = new User();
            user.Id = 48;

            //without dependancy Injection
            userDeleteOperation userDelete = new userDeleteOperation();
            userDelete.DeleteUser(user.Id);

           /* //dependancy Injection
            IuserDeleteOperation service2 = ServiceFactory.getService2();
            service2.DeleteUser(user.Id);
            */
            
        }
    }
}
