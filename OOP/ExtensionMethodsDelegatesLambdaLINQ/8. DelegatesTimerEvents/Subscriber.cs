using System;

namespace _8.DelegatesTimerEvents
{
    class Subscriber
    {
        public void Subscribe(Publisher publish)
        {
            publish.RaiseCustomEvent += new Publisher.TimerDelegate(Message); //the event is attached to the delegate
        }

        public void Message(Publisher publish, EventArgs e)
        {
            Console.WriteLine("Message");
        }
    }
}
