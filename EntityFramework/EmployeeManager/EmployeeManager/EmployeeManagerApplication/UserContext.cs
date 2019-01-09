using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerApplication
{
    class UserContext
    {
        public static string UserName { get; set; }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(UserName);
    }
}
