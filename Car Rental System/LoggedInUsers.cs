using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    class LoggedInUsers : Users
    {
        public override void set(string userName,string authLevel)
        {
            Users.userName = userName;
            Users.authLevel = authLevel;
        }

        public LoggedInUsers(string userName,string authLevel)
        {
            set(userName,authLevel);
        }
    }
}
