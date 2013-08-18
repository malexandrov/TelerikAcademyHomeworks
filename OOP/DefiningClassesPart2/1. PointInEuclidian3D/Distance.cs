using System;

namespace _1.PointInEuclidian3D
{
    public static class Distance
    {
        public static double CalcDistance(Point3D FirstPoint, Point3D SecondPoint)
        {
            double distance = Math.Sqrt((FirstPoint.X - SecondPoint.X) * (FirstPoint.X - SecondPoint.X) +
                                         (FirstPoint.Y - SecondPoint.Y) * (FirstPoint.Y - SecondPoint.Y) +
                                         (FirstPoint.Z - SecondPoint.Z) * (FirstPoint.Z - SecondPoint.Z));
            return distance;
        }
    }
}
