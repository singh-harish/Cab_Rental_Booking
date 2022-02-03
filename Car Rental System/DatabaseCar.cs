using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    class DatabaseCar : Data
    {
        public override void set(string color
         , string engine
         , string name
         , string stockNumber
         , string licenseNo
         , string vin
         , string make
         , string year
         , string vehicleClass
         , string weight
         , string transmission
         , string firstDate
         , string eningeType
         , string availaibility
         , string sold
         , string ratesDaily
         , string ratesWeekly
         , string ratesMonthly
         , string hourlyRate
         , string weekExtraDay
         , string monthExtraDay
         , string imageLocation
         , string freeMilePerDay
         , string ratePerExtra
         , string currentStatus
         , string meter
         , string fuelLevel
         , string notes)
        {
            this.color = color;
            this.engine = engine;
            this.name = name;
            this.engine = engine;
            this.stockNumber = stockNumber;
            this.licenseNo = licenseNo;
            this.vin = vin;
            this.make = make;
            this.year = year;
            this.vehicleClass = vehicleClass;
            this.weight = weight;
            this.transmission = transmission;
            this.firstDate = firstDate;
            this.eningeType = eningeType;
            this.availaibility = availaibility;
            this.sold = sold;
            this.ratesDaily = ratesDaily;
            this.ratesWeekly = ratesWeekly;
            this.ratesMonthly = ratesMonthly;
            this.hourlyRate = hourlyRate;
            this.weekExtraDay = weekExtraDay;
            this.monthExtraDay = monthExtraDay;
            this.imageLocation = imageLocation;
            this.freeMilePerDay = freeMilePerDay;
            this.ratePerExtra = ratePerExtra;
            this.currentStatus = currentStatus;
            this.meter = meter;
            this.fuelLevel = fuelLevel;
            this.notes = notes;
        }

        public DatabaseCar(
           string color
         , string engine
         , string name
         , string stockNumber
         , string licenseNo
         , string vin
         , string make
         , string year
         , string vehicleClass
         , string weight
         , string transmission
         , string firstDate
         , string eningeType
         , string availaibility
         , string sold
         , string ratesDaily
         , string ratesWeekly
         , string ratesMonthly
         , string hourlyRate
         , string weekExtraDay
         , string monthExtraDay
         , string imageLocation
         , string freeMilePerDay
         , string ratePerExtra
         , string currentStatus
         , string meter
         , string fuelLevel
         , string notes)
        {
            set(color
            , engine
            , name
            , stockNumber
            , licenseNo
            , vin
            , make
            , year
            , vehicleClass
            , weight
            , transmission
            , firstDate
            , eningeType
            , availaibility
            , sold
            , ratesDaily
            , ratesWeekly
            , ratesMonthly
            , hourlyRate
            , weekExtraDay
            , monthExtraDay
            , imageLocation
            , freeMilePerDay
            , ratePerExtra
            , currentStatus
            , meter
            , fuelLevel
            , notes);
        }
    }
}
