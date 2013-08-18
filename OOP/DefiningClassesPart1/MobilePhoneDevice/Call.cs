using System;
using System.Text;

namespace MobilePhoneDevice
{
    class Call
    {
        // Fileds
        private DateTime dateTime;
        private ulong dialedNumber;
        private int callDuration;  // in seconds

        // Constructors (not logical to skip any so only full constructor)
        public Call(DateTime dateTime, ulong dialedNumber, int callDuration)
        {
            this.dateTime = dateTime;
            this.dialedNumber = dialedNumber;
            this.callDuration = callDuration;
        }

        // Properties
        public DateTime DateTime
        {
            get { return DateTime; }
            set { DateTime = value; }
        }

        public ulong DialedNumber 
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public int CallDuration 
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }

        public override string ToString()
        {
            string callInfo = this.dateTime.ToString() +" Number: "+ this.dialedNumber+" Duration: "+this.callDuration;
            return callInfo;
        }
    }
}
