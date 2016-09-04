using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
//using System.Collections.Generic;
using System.Data.Common;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UserManagementOperation 
{
    public class userDeleteOperation : IuserDeleteOperation
    {
        private const string DBName = "HotelBookingMan";
        public void DeleteUser(Int64 Id)
        {
            DatabaseProviderFactory dbfactory = new DatabaseProviderFactory();
            Database defaultDB = dbfactory.CreateDefault();
            Database database = dbfactory.Create(DBName);
            DbCommand dbcommand = database.GetStoredProcCommand("spDeleteUser");

            database.AddInParameter(dbcommand, "@Id", System.Data.DbType.Int64, Id);
            database.ExecuteNonQuery(dbcommand);
         
            
        }

       
    }
}
