using System;
using System.Collections.Generic;

namespace _1.PointInEuclidian3D
{
    public class Path
    {
        private static List<Point3D> pointsList= new List<Point3D>();
        
        public List<Point3D> Paths { get { return pointsList; } }

        public void AddPoint(Point3D point)
        {
            pointsList.Add(point);
        }

        public void ClearPath()
        {
            pointsList.Clear();
        }


    }
}
