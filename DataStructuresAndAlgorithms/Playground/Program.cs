using Microsoft.VisualBasic;
using ZTMCodeInterview;

namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var bigO = new BigO();
            //bigO.MeasureTimeExecution();
            //bigO.LogAllPairsOfArray();

            Console.WriteLine(Fibonachi(10));
            Console.WriteLine(FibonachiDP(10));
        }


        static int Fibonachi(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }

        static int FibonachiDP(int number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;

            //f(0) = 0
            //f(1) = 1
            //f(n) = f(n - 1) + f(n - 2)
            
            int before = 0; //F(0)
            int current = 1; //F(1)
            int resultado = 0;

            for(int i = 2; i <= number; i++)
            {
                resultado = before + current;
                before = current;
                current = resultado;
            }

            return resultado;
        }
    }
}
