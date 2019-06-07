using System;
using System.Windows.Forms;

namespace Ass9
{
    class Vehicle
    {
        #region Private Variables
        string _year, _make, _model, _mileage, _vin;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (Int32.TryParse(value, out int numValue))
                    if (value.Length == 4)
                    {
                        _year = value;
                    }
                    else
                        throw new System.Exception(string.Format($"Invalid Entry'{value}' For Year"));
                else
                    throw new System.Exception(string.Format($"Invalid Entry'{value}' For Year"));
            }
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                if (value.Length > 0)
                    _make = value;
                else
                    throw new System.Exception(string.Format($"Invalid Entry'{value}' For Make"));
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length > 0)
                    _model = value;
                else
                    throw new System.Exception(string.Format($"Invalid Entry'{value}' For Model"));
            }
        }
        public string Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (long.TryParse(value, out long numValue))
                    _mileage = value;
                else
                    throw new System.Exception(string.Format($"Invalid Entry'{value}' For Mileage"));
            }
        }
        public string Vin
        {
            get
            {
                return _vin;
            }
            set
            {
                if (value.Length == 4)
                    _vin = value;
                else
                    throw new System.Exception(string.Format($"Invalid Entry'{value}' For VIN (Last 4  Digits)"));
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor with mileage for used car
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="mileage"></param>
        /// <param name="vin"></param>
        public Vehicle(int id, string year, string make, string model, string mileage, string vin)
        {
            Id = id;
            Year = year;
            Make = make;
            Model = model;
            Vin = vin;
            Mileage = mileage;
        }
        /// <summary>
        /// constructor without mileage for new car
        /// </summary>
        /// <param name="id"></param>
        /// <param name="year"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="vin"></param>
        public Vehicle(int id, string year, string make, string model, string vin)
        {
            Id = id;
            Year = year;
            Make = make;
            Model = model;
            Vin = vin;
            Mileage = "0";
        }
        #endregion

        #region Methods
        public void ShowInfo()
        {
            MessageBox.Show("Vehicle #" + this.Id + " added! Vehicle #" + this.Id + " is a " + this.Year + " "
                + this.Make + " " + this.Model + " " + "vehicle with " + this.Mileage + " miles on it. The last four digits of VIN is " + this.Vin);
        }
        #endregion
    }
}
