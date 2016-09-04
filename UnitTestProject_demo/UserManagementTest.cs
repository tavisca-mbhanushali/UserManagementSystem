using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Linq;
//using LinqData;
using UserManagementLibrary;
using UserManagementOperation;

namespace UnitTestProject_demo
{
    [TestClass]
    public class UserManagementTest
    {
        [TestMethod]
        public void TestCreateUser()
        {
            User user = new User();
             user.Id = 1102;
             user.FirstName = "Albert";
             user.LastName = "Einstaein";
             user.EmailId = "ae@gmail.com";
             user.PhoneNumber = "1000000000";

            //without dependancy injection
           // UserOperationDB userInsert = new UserOperationDB();
           // userInsert.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);

            IuserOperationDB service = ServiceFactory.getService();
            service.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);
            Int64 collectId = service.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);
            Assert.IsTrue(collectId > 0);
        }



        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCreateUserExceptionOnInvalidUserId()
        {
            User user = new User();
            user.Id = 0;
            user.FirstName = "Harshal";
            user.LastName = "Gibbs";
            user.EmailId = "hg@gmail.com";
            user.PhoneNumber = "7964551233";

            //without dependancy injection
            // UserOperationDB userInsert = new UserOperationDB();
            // userInsert.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);

            IuserOperationDB service = ServiceFactory.getService();
            service.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);

            Int64 collectId = service.InsertUser(user.Id, user.FirstName, user.LastName, user.EmailId, user.PhoneNumber);
            Assert.IsTrue(collectId > 0);

            //Assert.IsNotNull(new User());
            //Assert.IsTrue(new User().Id > 0);

        }

       

        }
    }

