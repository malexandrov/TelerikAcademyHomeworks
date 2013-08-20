namespace SizeClass_Exercise1
{
    using System;

    class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }            
        }

        public double Height
        {
            get
            {
                return this.height;
            }
        }
    }
}