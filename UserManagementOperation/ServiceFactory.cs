using Microsoft.Practices.Unity;
using UserManagementOperation;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UserManagementOperation
{
   public static class ServiceFactory
    {  
        public static UserOperationDB getService()
        {   //For Insert 
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IuserOperationDB, UserOperationDB>();
            UserOperationDB service = container.Resolve<UserOperationDB>();
            return service;

        }

        public static userUpdateOperation getService1()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IuserUpdateOperation, userUpdateOperation>();
            userUpdateOperation service = container.Resolve<userUpdateOperation>();
            return service;

        }

       /* // code for commented dependancy injection in deletetest
         public static userDeleteOperation getService2()
         {
             IUnityContainer container = new UnityContainer();
             container.RegisterType<IuserDeleteOperation, userDeleteOperation>();
             userDeleteOperation service = container.Resolve<userDeleteOperation>();
             return service;

         }
         */






    }
}
