using System;

namespace MobilePhoneDevice
{
    class Display
    {
        // Display class fields
        private string size;
        private int? numberOfColors;

        // Display constructors
        public Display(string size)
            : this(size, null)
        {
        }

        public Display(string size, int? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        // Properties for the Display
        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set 
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Number of display colors can't be negative!");
                }

                else
                {
                    this.numberOfColors = value;
                }
            }
        }
    }
}
