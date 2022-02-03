using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    abstract class Data
    {
        protected string color;
        protected string engine;
        protected string name;
        protected string stockNumber;
        protected string licenseNo;
        protected string vin;
        protected string make;
        protected string year;
        protected string vehicleClass;
        protected string weight;
        protected string transmission;
        protected string firstDate;
        protected string eningeType;
        protected string availaibility;
        protected string sold;
        protected string ratesDaily;
        protected string ratesWeekly;
        protected string ratesMonthly;
        protected string hourlyRate;
        protected string weekExtraDay;
        protected string monthExtraDay;
        protected string imageLocation;
        protected string freeMilePerDay;
        protected string ratePerExtra;
        protected string currentStatus;
        protected string meter;
        protected string fuelLevel;
        protected string notes;


        public abstract void set(string color
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
         , string notes);

        public string Color
        {
            get
            {
                return color;
            }
        }
        public string Engine
        {
            get
            {
                return engine;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string StockNumber
        {
            get
            {
                return stockNumber;
            }
        }
        public string LicenseNo
        {
            get
            {
                return licenseNo;
            }
        }
        public string Vin
        {
            get
            {
                return vin;
            }
        }
        public string Make
        {
            get
            {
                return make;
            }
        }
        public string Year
        {
            get
            {
                return year;
            }
        }
        public string VehicleClass
        {
            get
            {
                return vehicleClass;
            }
        }
        public string Weight
        {
            get
            {
                return weight;
            }
        }
        public string Transmission
        {
            get
            {
                return transmission;
            }
        }
        public string FirstDate
        {
            get
            {
                return firstDate;
            }
        }
        public string EningeType
        {
            get
            {
                return eningeType;
            }
        }
        public string Availaibility
        {
            get
            {
                return availaibility;
            }
        }
        public string Sold
        {
            get
            {
                return sold;
            }
        }
        public string RatesDaily
        {
            get
            {
                return ratesDaily;
            }
        }
        public string RatesWeekly
        {
            get
            {
                return ratesWeekly;
            }
        }
        public string RatesMonthly
        {
            get
            {
                return ratesMonthly;
            }
        }
        public string HourlyRate
        {
            get
            {
                return hourlyRate;
            }
        }
        public string WeekExtraDay
        {
            get
            {
                return weekExtraDay;
            }
        }
        public string MonthExtraDay
        {
            get
            {
                return monthExtraDay;
            }
        }
        public string ImageLocation
        {
            get
            {
                return imageLocation;
            }
        }
        public string FreeMilePerDay
        {
            get
            {
                return freeMilePerDay;
            }
        }
        public string RatePerExtra
        {
            get
            {
                return ratePerExtra;
            }
        }
        public string CurrentStatus
        {
            get
            {
                return currentStatus;
            }
        }
        public string Meter
        {
            get
            {
                return meter;
            }
        }
        public string FuelLevel
        {
            get
            {
                return fuelLevel;
            }
        }
        public string Notes
        {
            get
            {
                return notes;
            }
        }

        public override string ToString()
        {
            // construct the representation that you want and return it.

            return String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27}"
            , color
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
