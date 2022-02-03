using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    [Serializable]
    class Admins : Logins
    {
        public override void set(string name, string pass, string privelage)
        {
            this.name = name;
            this.pass = pass;
            this.privelage = privelage;
        }

        public Admins(string name, string pass, string privelage)
        {
            set(name, pass, privelage);
        }
    }
}
