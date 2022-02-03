using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    abstract class Users
    {
        public static string userName;
        public static string authLevel;

        public abstract void set(string userName, string authLevel);

        public string UserName
        {
            get
            {
                return userName;
            }
        }
        public string AuthLevel
        {
            get
            {
                return authLevel;
            }
        }
    }
}
