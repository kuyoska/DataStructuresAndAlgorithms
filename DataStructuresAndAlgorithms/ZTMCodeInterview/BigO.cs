using System.Diagnostics;

namespace ZTMCodeInterview
{
    public class BigO
    {
        public void MeasureTimeExecution()
        {
            long startTime = Stopwatch.GetTimestamp();
            // Your code: Doing something e.g
            Thread.Sleep(3000);
            TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
            Console.WriteLine(elapsedTime.TotalSeconds);
        }
    }
}
