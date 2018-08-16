using System;

namespace BumBangApplication
{
    public class TimerClass : ITimerClass
    {
        private System.Timers.Timer _timer;

        public Action OnElapsedEventHandler { get; set; }

        public int IntervalInSeconds { get; set; }

        public void Start()
        {
            if (_timer != null) _timer.Close();
            _timer = new System.Timers.Timer();
            _timer.Interval = IntervalInSeconds * 1000;
            _timer.Elapsed += Timer_Elapsed;
            _timer.AutoReset = true;
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
            _timer.Close();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            OnElapsedEventHandler?.Invoke();
        }
    }
}
