using System;

namespace BumBangApplication
{
    public interface ITimerClass
    {
        Action OnElapsedEventHandler { set; }
        int IntervalInSeconds { set; }
        void Start();
        void Stop();
    }
}
