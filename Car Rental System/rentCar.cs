using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    class RentCar : userData
    {
        public override void set(string firstName, string middleName, string lastName, string gender, string nic, string contactno, string dob
            , string occupation, string permenentAdress, string homeAdress, string carName, string dateOfRenting, string dateOfReturn
            , string pickupLocation, string carStatus, string totalDays, string pricePerDay, string totalPrice)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.gender = gender;
            this.nic = nic;
            this.contactno = contactno;
            this.dob = dob;
            this.occupation = occupation;
            this.permenentAdress = permenentAdress;
            this.homeAdress = homeAdress;
            this.carName = carName;
            this.dateOfRenting = dateOfRenting;
            this.dateOfReturn = dateOfReturn;
            this.pickupLocation = pickupLocation;
            this.carStatus = carStatus;
            this.totalDays = totalDays;
            this.pricePerDay = pricePerDay;
            this.totalPrice = totalPrice;
        }

        public RentCar(string firstName, string middleName, string lastName, string gender, string nic, string contactno, string dob
            , string occupation, string permenentAdress, string homeAdress, string carName, string dateOfRenting, string dateOfReturn
            , string pickupLocation, string carStatus, string totalDays, string pricePerDay, string totalPrice)
        {
            set(firstName, middleName, lastName, gender, nic, contactno, dob
                , occupation, permenentAdress, homeAdress, carName, dateOfRenting, dateOfReturn
                , pickupLocation, carStatus, totalDays, pricePerDay, totalPrice);
        }
    }
}
