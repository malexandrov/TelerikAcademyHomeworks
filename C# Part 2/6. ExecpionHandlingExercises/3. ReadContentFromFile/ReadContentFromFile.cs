using System;
using System.IO;
using System.Security;

class ReadContentFromFile
{
    static void Main()
    {
        string fileToRead = @"C:\windows\win.ini";

        try
        {
            ReadFile(fileToRead);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters.");
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission. ");
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }

    static void ReadFile(string path)
    {
        Console.WriteLine(path);
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
    }
}
