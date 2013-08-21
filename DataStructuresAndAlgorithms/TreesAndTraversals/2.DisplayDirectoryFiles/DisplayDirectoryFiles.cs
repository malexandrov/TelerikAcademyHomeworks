namespace DisplayDirectoryFiles
{
    using System;
    using System.Text;
    using System.IO;

    class DisplayDirectoryFiles
    {
        static void Main()
        {
            string path = @"C:\Windows";
            string extension = "*.exe";

            TraverseFiles(path, extension);
        }

        private static void TraverseFiles(string path, string extension)
        {
            StringBuilder stringbuilder = new StringBuilder();

            try
            {
                string[] exeFiles = Directory.GetFiles(path, extension);
                foreach (var file in exeFiles)
                {
                    stringbuilder.AppendLine(file);
                }
                Console.Write(stringbuilder.ToString());

                string[] directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    TraverseFiles(directory, extension);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Directory: {0}, can't be accessed!", path);
                return;
            }
        }
    }
}
