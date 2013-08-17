using System;
using System.Net;
using System.Security;

class DownloadFileFromInternet
{
    static void Main()
    {
        string remoteFileURL = @"http://www.devbg.org/img/";
        string remoteFileName = "Logo-BASD.jpg";
        WebClient webClient = new WebClient();

        try
        {

             webClient.DownloadFile(remoteFileURL, remoteFileName);
        }

        catch (WebException error)
        {
            Console.WriteLine(error.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have permission to write to local file.");
        }

        finally
        {
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", remoteFileName, remoteFileURL);
            webClient.Dispose();
            Console.WriteLine("Successfully Disposed resources");
        }
    }
}