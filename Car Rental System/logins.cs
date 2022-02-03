using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    [Serializable]
    abstract class Logins
    {
        protected string name;
        protected string pass;
        protected string privelage;
        public abstract void set(string name, string pass, string privelage);
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Pass
        {
            get
            {
                return pass;
            }
        }
        public string Privelage
        {
            get
            {
                return privelage;
            }
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2}", name, pass, privelage);
        }
    }
}
