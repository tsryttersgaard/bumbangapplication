using System;

namespace BumBangApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IBumBangCounter counter = new BumBangCounter();
            ITimerClass timer = new TimerClass
            {
                IntervalInSeconds = 1,
                OnElapsedEventHandler = delegate ()
                {
                    OnTimerElapsed(ref counter);
                }
            };
            Console.WriteLine("Press 'q' to stop or wait until we reach 100...");
            timer.Start();
            while (Console.ReadKey().Key != ConsoleKey.Q && counter.Counter < 101);
            timer.Stop();
        }

        static void OnTimerElapsed(ref IBumBangCounter counter)
        {
            Console.Write(counter.Counter);
            if (counter.IsDevidableByThree) Console.Write(" bum");
            if (counter.IsDevidableBySeven) Console.Write(" bang");
            Console.WriteLine();
            counter.AddUp();
        }
    }
}
