using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementOperation
{
   public interface IuserUpdateOperation
    {
        void UpdateUser(Int64 Id, string FirstName, string LastName, string EmailId, string PhoneNumber);
    }
}
