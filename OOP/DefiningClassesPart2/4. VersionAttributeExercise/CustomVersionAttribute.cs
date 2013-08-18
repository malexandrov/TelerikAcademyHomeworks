using System;

namespace _4.VersionAttributeExercise
{
    [Version("1.12.006")]

    class CustomVersionAttribute
    {
        static void Main(string[] args)
        {
            Type type = typeof(CustomVersionAttribute);
            object[] attributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine("This class is version {0}", attribute.Version);
            }
        }
    }
}
