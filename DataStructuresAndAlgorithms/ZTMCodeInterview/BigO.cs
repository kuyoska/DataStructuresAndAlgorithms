using System.Diagnostics;

namespace ZTMCodeInterview
{
    public class BigO
    {
        /// <summary>
        /// This is a way to measure execution time, but Big O is a better way to meaure compute complexity of an algorightm
        /// </summary>
        public void MeasureTimeExecution()
        {
            long startTime = Stopwatch.GetTimestamp();
            // Your code: Doing something e.g
            Thread.Sleep(3000);
            TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
            Console.WriteLine(elapsedTime.TotalSeconds);
        }

        /// <summary>
        /// This is O(n^2) cuadratic execution complexity
        /// </summary>
        public void LogAllPairsOfArray()
        {
            int[] array = [1, 2, 3, 4, 5];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine($"{array[i]} {array[j]}");
                }
            }
        }

        /// <summary>
        /// This is O(n) as we simulate the javascript array.push(element) wich insert a new element at the end
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int[] ArrayPush(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[array.Length] = value;

            return newArray;
        }

        /// <summary>
        /// This is O(n) as we simulate the javascript array.pop(element) which remove last element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int[] ArrayPop(int[] array)
        {
            int[] newArray = new int[array.Length -1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        /// <summary>
        /// This is O(n) as we simulate the javascript array.shift(element) which remove the first element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int[] ArrayShift(int[] array)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i] = array[i + 1];
            }

            return newArray;
        }

        /// <summary>
        /// This is O(n) as we simulate the javascript array.unshift(element) which add element at the start
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int[] ArrayUnShift(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 1; i <= array.Length; i++)
            {
                newArray[i] = array[i - 1];
            }

            newArray[0] = value;

            return newArray;
        }
    }
}
