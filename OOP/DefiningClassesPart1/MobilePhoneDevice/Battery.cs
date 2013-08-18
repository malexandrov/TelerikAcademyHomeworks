using System;

public enum BatteryType { NiMH, LiIon, NiCd, NiZn };

namespace MobilePhoneDevice
{
    class Battery
    {
        // Battery class fields
        private BatteryType batteryType;
        private string batteryModel;
        private int? hoursIdle;
        private int? hoursTalk;

        // Thee constructors for the Battery class
        public Battery(string batteryModel, BatteryType batteryType)
            : this(batteryModel, batteryType, null, null)
        {
        }

        public Battery(string batteryModel, BatteryType batteryType, int? hoursIdle)
            : this(batteryModel, batteryType, hoursIdle, null)
        {
        }

        public Battery(string batteryModel, BatteryType batteryType, int? hoursIdle, int? hoursTalk)
        {
            this.batteryModel = batteryModel;
            this.batteryType = batteryType;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        // Properties for the battery
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            { 
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Hours idle must be a positive number!");
                }

                else
                {
                    this.hoursIdle = value;
                }                
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Hours talk must be a positive number!");
                }

                else
                {
                    this.hoursTalk = value;
                }
            }
        }
    }
}
