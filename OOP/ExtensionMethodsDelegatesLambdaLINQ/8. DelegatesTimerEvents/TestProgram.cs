using System;

namespace _8.DelegatesTimerEvents
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Publisher publish = new Publisher(); //publisher is the class that causes an event at a set interval
            Subscriber subscribe = new Subscriber(); //subscriber subcribes to event notifications and prints a message at each event

            publish.TimeInterval = 2000;
            subscribe.Subscribe(publish);

            publish.Start();
        }
    }
}
