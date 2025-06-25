using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmicThinking
{
    /// <summary>
    /// This class contains code tips that I considered interesting and extracted from the book C# and Algorithmic Thinking for the Complete Begginer
    /// </summary>
    public class ATLibrary
    {
        /// <summary>
        /// Operators *,/,% have higher precedence than +, -. If two higher operators are in the same expression they are performed left to right
        /// </summary>
        /// <returns></returns>
        public int TwoHigherOperatorsInSameExpression()
        {
            int y = 6 / 3 * 2;

            return y;
        }

        /// <summary>
        /// Compute the square root using Math.Pow
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double SquareRootUsingPOW(double x)
        {
            double y = Math.Pow(x, 1 / 2.0);

            return y;
        }

        /// <summary>
        /// Compute the cubic root using Math.Pow
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double CubicRootUsingPOW(double x)
        {
            double y = Math.Pow(x, 1 / 3.0);

            return Math.Round(y);
        }

        /// <summary>
        /// Sums the digits of a four digit integer isolating from right to left, example 6541 -> result = 6 + 5 + 4 + 1 = 16 
        /// </summary>
        /// <param name="fourDigitInt"></param>
        /// <returns></returns>
        public int SumOfDigitsOf4DigitsIntFirstApproach(int fourDigitInt)
        {
            int firstDigit = fourDigitInt / 1000;
            int reminder = fourDigitInt % 1000;
            int secondDigit = reminder / 100;
            reminder = reminder % 100;
            int thirdDigit = reminder / 10;
            int fourthDigit = reminder % 10;

            return firstDigit + secondDigit + thirdDigit + fourthDigit;
        }

        /// <summary>
        /// Sums the digits of a four digit integer isolating from left to right, example 6541 -> result = 6 + 5 + 4 + 1 = 16 
        /// </summary>
        /// <param name="fourDigitInt"></param>
        /// <returns></returns>
        public int SumOfDigitsOf4DigitsIntSecondApproach(int fourDigitInt)
        {
            int fourthDigit = fourDigitInt % 10;
            int reminder = fourDigitInt / 10;
            int thirdDigit = reminder % 10;
            reminder = reminder / 10;
            int secondDigit = reminder % 10;
            int firstDigit = reminder / 10;

            return firstDigit + secondDigit + thirdDigit + fourthDigit;
        }

        /// <summary>
        /// Converting and integer containing a elapsed time in seconds to a DD day(s) HH hour(s) MM minute(s) and SS second(s) string
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public string ElapsedSecondsToTimeFirstApproach(int seconds)
        {
            int days = (int)(seconds / 86400);
            int reminder = seconds % 86400;
            int hours = (int)(reminder / 3600);
            reminder = reminder % 3600;
            int minutes = (int)(reminder / 60);
            seconds = reminder % 60;

            return $"{days} day(s) {hours} hour(s) {minutes} minute(s) and {seconds} second(s)";
        }

        /// <summary>
        /// Converting and integer containing a elapsed time in seconds to a DD day(s) HH hour(s) MM minute(s) and SS second(s) string
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public string ElapsedSecondsToTimeSecondApproach(int seconds)
        {
            int secondsX = seconds % 60;
            int reminder = seconds / 60;
            int minutes = reminder % 60;
            reminder = reminder / 60;
            int hours = reminder % 24;
            int days = reminder / 24;

            return $"{days} day(s) {hours} hour(s) {minutes} minute(s) and {secondsX} second(s)";
        }

        /// <summary>
        /// Reverses a three digit number, example 541 -> 145
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int ReversedThreeDigitNumber(int number)
        {
            int digit1, digit2, digit3, reminder;

            digit3 = number % 10;
            reminder = (int)number / 10;
            digit2 = reminder % 10;
            digit1 = (int)reminder / 10;

            return digit3 * 100 + digit2 * 10 + digit1;
        }

        /// <summary>
        /// Progressive rates calculates the rates based on following table
        /// energyConsumed ≤ 500 $0.10
        /// 501 ≤ energyConsumed ≤ 2000  
        /// 2001 ≤ energyConsumed ≤ 450
        /// 4501 ≤ energyConsumed
        /// </summary>
        /// <param name="energyConsumed"></param>
        /// <returns></returns>
        public double ProgressiveRates(int energyConsumed)
        {
            if (energyConsumed <= 500) return energyConsumed * .10;
            else if (energyConsumed > 501 && energyConsumed < 2000)
            {
                return (500) * .10 + (energyConsumed - 500) * .25;
            }
            else if (energyConsumed > 2001 && energyConsumed < 4500)
            {
                return (500) * .10 + (1500) * .25 + (energyConsumed - 2000) * .40;
            }
            else if (energyConsumed > 4501)
                return (500) * .10 + (1500) * .25 + (2500) * .40 + (energyConsumed - 4500) * .60;

            return double.PositiveInfinity;
        }

        /// <summary>
        /// Sorts an int array using Bubble Sort algorithm
        /// </summary>
        /// <param name="array"></param>
        public void BubbleSort(int[] array)
        {
            bool swap = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                swap = false;
                for (int j = array.Length - 1; j > i; j--)
                {
                    if(array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        swap = true;
                    }
                }

                if (!swap) break;
            }
        }

        /// <summary>
        /// Sorts an int array using Selection Sort Algorithm
        /// </summary>
        /// <param name="array"></param>
        public void SelectionSort(int[] array)
        {
            int minimun;
            int minPos = 0;

            for(int i = 0;i < array.Length - 1;i++)
            {
                minimun = array[i];

                for(int j = i + 1; j <= array.Length - 1; j++)
                {
                    if(array[j] < minimun )
                    {
                        minimun = array[j];
                        minPos = j;
                    }                        
                }

                var temp = array[i];
                array[i] = minimun;
                array[minPos] = temp;
            }
        }

        /// <summary>
        /// Sorts an int array using Insertion Sort Algorithm
        /// </summary>
        /// <param name="array"></param>
        public void InsertionSort(int[] array)
        {
            int element;
            int n;

            for(int i = 1; i <= array.Length - 1; i++)
            {
                element = array[i];
                n = i;

                while (n > 0 && array[n - 1] > element)
                {
                    array[n] = array[n - 1];
                    n--;
                }

                array[n] = element;
            }
        }

        /// <summary>
        /// Searchs an element in an sorted array using binary search
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public int BinarySearch(int[] array, int value)
        {
            int left = 0;
            int right= array.Length - 1;
            int middle = (left + right) / 2;

            while (left < right)
            {
                if (array[middle] > value)
                {
                    right = middle - 1;
                }
                else if(array[middle] < value)
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }

                middle = (left + right) / 2;
            }

            return -1;
        }
    }
}
