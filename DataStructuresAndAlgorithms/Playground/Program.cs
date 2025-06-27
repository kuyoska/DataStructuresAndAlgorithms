using ZTMCodeInterview;

namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var bigO = new BigO();
            bigO.MeasureTimeExecution();
            bigO.LogAllPairsOfArray();
        }
    }
}
