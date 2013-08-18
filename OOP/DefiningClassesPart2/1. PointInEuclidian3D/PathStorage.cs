using System;
using System.Collections.Generic;
using System.IO;

namespace _1.PointInEuclidian3D
{
    static class PathStorage
    {
        public static void SaveTXT(Path path)
        {
            using (StreamWriter write = new StreamWriter(@"../../SavedPath.txt"))
            {
                foreach (var point in path.Paths)
                {
                    write.WriteLine(point);
                }
            }
        }
        
        public static Path LoadTXT()
        {
            Path pathFromFile = new Path();
            using (StreamReader read = new StreamReader(@"../../PathToLoad.txt"))
            {
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine();
                    string[] coords = line.Split(',');
                    Point3D newPoint = new Point3D( int.Parse(coords[0]), int.Parse(coords[1]), int.Parse(coords[2]) );
                    pathFromFile.AddPoint(newPoint);
                }
            }
            return pathFromFile;
        }
    }
}
