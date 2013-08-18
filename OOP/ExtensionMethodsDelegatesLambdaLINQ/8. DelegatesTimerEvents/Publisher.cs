using System;
using System.Threading;

namespace _8.DelegatesTimerEvents
{
    class Publisher
    {
        public delegate void TimerDelegate(Publisher publish, EventArgs e); // Delegate to which the event is attached
        public event TimerDelegate RaiseCustomEvent;                        // Event 
        public EventArgs e = null;

        public int TimeInterval { get; set; }
        private int counter = 0;

        public void Start()
        {
            while (counter < 10)
            {
                if (RaiseCustomEvent != null)
                {
                    RaiseCustomEvent(this, e);
                }
                Thread.Sleep(TimeInterval);
                counter++;
            }
        }
    }
}
