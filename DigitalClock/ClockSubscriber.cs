using System;

namespace DigitalClock
{
    public class ClockSubscriber
    {
        public void Susbscribe(ClockPublisher publisher)
        {
            publisher.SecondChange += new ClockPublisher.SecondChangeHandler(TimeHasChanged);
        }

        private void TimeHasChanged(ClockPublisher publisher, Clock time)
        {
            Console.WriteLine($"The current time is {time.Hour}:{time.Minute}:{time.Second}");
        }
    }
}