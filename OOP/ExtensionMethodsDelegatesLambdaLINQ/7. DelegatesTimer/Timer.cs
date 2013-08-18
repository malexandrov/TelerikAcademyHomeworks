using System;
using System.Threading;

namespace _7.DelegatesTimer
{
    public delegate void TimerDelegate(int ticks);

    public class Timer
    {
        public int TickCounter { get; private set; } 
        public int Interval { get; private set; }
        private TimerDelegate callBack;

        public Timer(int tickCounter, int interval, TimerDelegate callBack) // constructor
        {
            this.TickCounter = tickCounter;
            this.Interval = interval;
            this.callBack = callBack;
        }

        public void Start()
        {
            int ticks = this.TickCounter;
            while (ticks > 0)
            {
                Thread.Sleep(Interval);
                ticks--;
                this.callBack(ticks);
            }
        }

    }
}
