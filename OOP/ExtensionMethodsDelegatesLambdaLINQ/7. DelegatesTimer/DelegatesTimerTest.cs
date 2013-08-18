using System;
using System.Threading;

namespace _7.DelegatesTimer
{
    class DelegatesTimerTest
    {
        static void Main(string[] args)
        {
            TimerDelegate testDelegate = new TimerDelegate(PrintMessage);
            Timer testTimer = new Timer(5, 2000, testDelegate);

            Thread thread = new Thread(new ThreadStart(testTimer.Start));
            thread.Start();
        }

        static void PrintMessage(int ticks)
        {
            Console.WriteLine("Some text to display each time..");
        }
    }
}
