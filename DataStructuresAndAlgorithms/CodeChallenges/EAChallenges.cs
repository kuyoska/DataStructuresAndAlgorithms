using System.Collections.Generic;
using System.Text;

namespace CodeChallenges
{
    public class EAChallenges
    {
        public int CalculateSumOfDigits(int fourDigitInt)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += fourDigitInt % 10; // Add the last digit to the sum
                fourDigitInt /= 10; // Remove the last digit
            }
            return sum;
        }

        public int CalculateSumOfDigitsUsingString(int fourDigitInt)
        {
            string numberString = fourDigitInt.ToString();
            int sum = 0;
            foreach (char digit in numberString)
            {
                sum += digit - '0'; // Convert char to int
            }
            return sum;
        }


        /// <summary>
        /// Finds the number in the provided array that is closest to zero.
        /// </summary>
        /// <param name="numbers">An array of integers to search. Must not be null.</param>
        /// <returns>The integer closest to zero. If two numbers are equally close to zero, the positive number is returned.
        /// Returns 0 if the array is empty.</returns>
        public int ComputeClosesToZero(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            int closest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                var number = numbers[i];
                if (Math.Abs(number) < Math.Abs(closest) || 
                    (Math.Abs(number) == Math.Abs(closest) && number > closest)//this handles the case where two numbers are equally close to zero, we prefer the positive one
                    )
                {
                    closest = number;
                }
            }
            return closest;
        }

        /// <summary>
        /// Determines whether the given number is a duo-digit number.
        /// </summary>
        /// <remarks>A duo-digit number is defined as a number that consists of at most two distinct
        /// digits. For example, 121 and -33 are duo-digit numbers, while 123 is not.</remarks>
        /// <param name="number">The integer to evaluate. Can be positive, negative, or zero.</param>
        /// <returns><see langword="yes"/> if the number contains no more than two unique digits;  otherwise, <see
        /// langword="no"/>. </returns>
        public string IsDuoDigit(int number)
        {
            HashSet<int> uniqueDigits = new HashSet<int>();

            string ditigString = Math.Abs(number).ToString();

            foreach (var charDigit in ditigString)
            {
                if (!uniqueDigits.Contains(charDigit))
                    uniqueDigits.Add(charDigit);
                
                if (uniqueDigits.Count > 2)
                    return "no";
            }
            return "yes";
        }

        /// <summary>
        /// Reshapes the input string by inserting line breaks after a specified number of characters.
        /// </summary>
        /// <remarks>Spaces in the input string are ignored when counting characters for line breaks. The
        /// method does not trim or modify the input string other than inserting line breaks.</remarks>
        /// <param name="n">The maximum number of characters per line before a line break is inserted. Must be greater than zero.</param>
        /// <param name="str">The input string to reshape. Cannot be null.</param>
        /// <returns>A new string with line breaks inserted after every <paramref name="n"/> characters, excluding spaces.</returns>
        public string Reshape(int n, string str)
        {
            var result = new StringBuilder();
            int cont = 0;
            foreach (var _char in str)
	{
                if (_char != ' ')
                    result.Append(_char);
                cont++;
                if (cont == n)
                {
                    cont = 0;
                    result.Append(Environment.NewLine);
                }

            }
            return result.ToString().TrimEnd();
        }
    }
}
