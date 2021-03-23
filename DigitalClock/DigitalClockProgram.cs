// using DigitalClock;

namespace DigitalClock
{
    public class DigitalClockProgram
    {
        public static void Run()
        {
            ClockPublisher publisher = new ClockPublisher();
            ClockSubscriber subscriber = new ClockSubscriber();

            subscriber.Susbscribe(publisher);
            publisher.Run();                        
        }
    }
}