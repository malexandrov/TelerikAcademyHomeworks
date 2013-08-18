using System;

namespace _1.PointInEuclidian3D
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Center of Euclidian space: " + Point3D.Center);       // Print coordinate start

            Point3D point1 = new Point3D(3, 5, 1);   // Create some points and use the overriden ToString to print the coordinates
            Point3D point2 = new Point3D(1, 2, 3);
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine();

            Console.WriteLine("Distance: " + Distance.CalcDistance(point1, point2));   // Calculate the distance     
            Console.WriteLine();

            Path newPath = new Path();           // Add the points to a new path
            newPath.AddPoint(point1);       
            newPath.AddPoint(point2);
            PathStorage.SaveTXT(newPath);        // Save path to SavedPath.txt
            newPath.ClearPath();                 // Clear

            newPath = PathStorage.LoadTXT();     // Load coordinates for points from file PathToLoad.txt

            Console.WriteLine("Points loaded from file:");
            foreach (var point in newPath.Paths)
            {
                Console.WriteLine(point);        // Print new points coordinates
            }            
        }
    }
}
