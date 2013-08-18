using System;

namespace _1.PointInEuclidian3D
{
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private static readonly Point3D CoordinateStart = new Point3D( 0, 0, 0 );

        public Point3D(int xCoodinate, int yCoordinate, int zCoordinate): this()
        {
            this.X = xCoodinate;
            this.Y = yCoordinate;
            this.Z = zCoordinate;
        }

        public static Point3D Center { get {return CoordinateStart ;} }

        public override string ToString()
        {
            string pointString = "Point {" + this.X + "," + this.Y + "," + this.Z + "}" ;
            return pointString;
        }
    }
}
