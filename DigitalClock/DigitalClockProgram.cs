// using DigitalClock;

namespace Tran_Duc_Anh_CSharpFundamentals_Day2.DigitalClock
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