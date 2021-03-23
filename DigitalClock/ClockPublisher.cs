using System;
using System.Threading;

namespace DigitalClock
{
    public class ClockPublisher
    {
        public delegate void SecondChangeHandler(ClockPublisher clockPublisher, Clock time);

        public event SecondChangeHandler SecondChange;

        public void OnSecondChange(ClockPublisher clockPublisher, Clock time)
        {
            SecondChange(clockPublisher, time);
        }

        public void Run()
        {
            while(true)
            {
                Thread.Sleep(1000);
                DateTime dateTimeNow = DateTime.Now;
                Clock clock = new Clock(dateTimeNow.Hour, dateTimeNow.Minute, dateTimeNow.Second);
                OnSecondChange(this, clock);
            }
        }
    }
}