using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementOperation
{
  public interface IuserOperationDB
    {
        Int64 InsertUser(Int64 Id, string FirstName, string LastName, string EmailId, string PhoneNumber);

    }
}
