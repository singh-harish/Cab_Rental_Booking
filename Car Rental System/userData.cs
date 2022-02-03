using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    abstract class userData
    {
        protected string firstName;
        protected string middleName;
        protected string lastName;
        protected string gender;
        protected string nic;
        protected string contactno;
        protected string dob;
        protected string occupation;
        protected string permenentAdress;
        protected string homeAdress;
        protected string carName;
        protected string dateOfRenting;
        protected string dateOfReturn;
        protected string pickupLocation;
        protected string carStatus;
        protected string totalDays;
        protected string pricePerDay;
        protected string totalPrice;

        public abstract void set(string firstName
        ,string middleName
        ,string lastName
        ,string gender
        ,string nic
        ,string contactno
        ,string dob
        ,string occupation
        ,string permenentAdress
        ,string homeAdress
        ,string carName
        ,string dateOfRenting
        ,string dateOfReturn
        ,string pickupLocation
        ,string carStatus
        ,string totalDays
        ,string pricePerDay
        ,string totalPrice);

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
        }
        public string Nic
        {
            get
            {
                return nic;
            }
        }
        public string Contactno
        {
            get
            {
                return contactno;
            }
        }
        public string Dob
        {
            get
            {
                return dob;
            }
        }
        public string Occupation
        {
            get
            {
                return occupation;
            }
        }
        public string PermenentAdress
        {
            get
            {
                return permenentAdress;
            }
        }
        public string HomeAdress
        {
            get
            {
                return homeAdress;
            }
        }
        public string CarName
        {
            get
            {
                return carName;
            }
        }
        public string DateOfRenting
        {
            get
            {
                return dateOfRenting;
            }
        }
        public string DateOfReturn
        {
            get
            {
                return dateOfReturn;
            }
        }
        public string PickupLocation
        {
            get
            {
                return pickupLocation;
            }
        }
        public string CarStatus
        {
            get
            {
                return carStatus;
            }
        }
        public string TotalDays
        {
            get
            {
                return totalDays;
            }
        }
        public string PricePerDay
        {
            get
            {
                return pricePerDay;
            }
        }
        public string TotalPrice
        {
            get
            {
                return totalPrice;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}"
            , firstName
            , middleName
            , lastName
            , gender
            , nic
            , contactno
            , dob
            , occupation
            , permenentAdress
            , homeAdress
            , carName
            , dateOfRenting
            , dateOfReturn
            , pickupLocation
            , carStatus
            , totalDays
            , pricePerDay
            , totalPrice);
        }
    }
}
