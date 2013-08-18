using System;
using System.Text;
using System.Collections.Generic;

namespace MobilePhoneDevice
{
    class GSM
    { //GSM fields
        private Battery Battery = new Battery("none", BatteryType.LiIon, null, null);
        private Display Display = new Display("none", null);
        private List<Call> callHistory= new List<Call>();

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        static private GSM iPhone4S = new GSM("iPhone", "Apple", 950.99m, "none");   // Exercise 6 - add static field for iFoune :)

        // Thee constructors for the GSM class
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //Exercise 4 - a method to display the info and override ToString()
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Model: " + this.model);
            info.AppendLine("Manufacturer: " + this.manufacturer);
            info.AppendLine("Price: " + this.price);
            info.AppendLine("Owned by: " + this.owner);
            info.AppendLine("Battery model: " + this.Battery.BatteryModel + "  Type: " + this.Battery.BatteryType +
                            "  Idle hours: " + this.Battery.HoursIdle + "  Talked hours: " + this.Battery.HoursTalk);
            info.AppendLine("Display size: " + this.Display.Size + "  Display colors: " + this.Display.NumberOfColors);
            return info.ToString();
        }

        // Properties for the GSM class
        public string Model 
        {
            get { return this.model; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid model");
                }

                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer 
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid manufacturer!");
                }

                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal? Price 
        { 
            get { return this.price; }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Price must be a positive number!");
                }

                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner 
        {
            get { return this.owner ;}
            set
            {
                if (value.Length <= 0 )
                {
                    throw new ArgumentOutOfRangeException("Invalid name of owner!");
                }

                else
                {
                    this.owner = value;
                }
             }
        }
        // iFoune property for task 6
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        // CallHistory - exercise 9
        public List<Call> CallHistory
        {
            get { return callHistory; }   // Returns a List
        }

        // Methods for call manipulations
        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }
        public void RemoveCall(int position)
        {
            if (position < 0 || position > callHistory.Count - 1)
            {
                throw new IndexOutOfRangeException("Call to remove must be in the range from 0 to number of calls!");
            }
            else
            {
                callHistory.RemoveAt(position);
            }
        }
        public void ClearHistory()
        {
            callHistory.Clear();
        }

        public decimal CalculatePrice(decimal pricePerMinute)
        {
            decimal talkTime = 0;

            foreach (var call in callHistory)
            {
                talkTime += call.CallDuration;
            }
            
            decimal totalPrice = (talkTime / 60) * pricePerMinute; 
            return totalPrice;
        }
    }
}
