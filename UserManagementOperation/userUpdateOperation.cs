﻿//using DBFactory;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
//using System.Collections.Generic;
using System.Data.Common;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UserManagementOperation
{
   public class userUpdateOperation : IuserUpdateOperation
    {
        private const string DBName = "HotelBookingMan";
        public void UpdateUser(Int64 Id, string FirstName, string LastName, string EmailId, string PhoneNumber)
        {
           

            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);

            DbCommand dbcommand = database.GetStoredProcCommand("spUpdateUser");

            database.AddInParameter(dbcommand, "@Id", System.Data.DbType.Int64, Id);

            if (Id == 0)
            {
                Console.WriteLine("Id Can not be zero ");
                throw new Exception();
            }
            database.AddInParameter(dbcommand, "@FirstName", System.Data.DbType.String, FirstName);
            database.AddInParameter(dbcommand, "@LastName", System.Data.DbType.String, LastName);
            database.AddInParameter(dbcommand, "@EmailId", System.Data.DbType.String, EmailId);
            database.AddInParameter(dbcommand, "@PhoneNumber", System.Data.DbType.String, PhoneNumber);
            database.ExecuteScalar(dbcommand);
        }
    }
}
