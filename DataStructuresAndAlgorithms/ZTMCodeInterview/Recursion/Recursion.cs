
namespace ZTMCodeInterview.Recursion
{
    public class Recursion
    {
        public int Factorial(int number)
        {
            if(number == 2)
                return 2;
            return number * Factorial(number - 1);
        }

        public int FactorialIterative(int number)
        {
            var factorial = number;

            for (int i = 1; i < number - 1; i++)
            {
                factorial *= number - i;
            }

            return factorial;
        }

        /// <summary>
        /// This is O(2^N)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int Fibonachi(int number)
        {
            if (number < 2) 
                return number;

            return Fibonachi(number - 1) + Fibonachi(number - 2);
        }

        public int FibonachiDP(int number)
        {
            if (number < 2)
                return number;

            //f(0) = 0
            //f(1) = 1
            //f(n) = f(n - 1) + f(n - 2)

            int before = 0; //F(0)
            int current = 1; //F(1)
            int resultado = 0;

            for (int i = 2; i <= number; i++)
            {
                resultado = before + current;
                before = current;
                current = resultado;
            }

            return resultado;
        }

        public int FibonachiIterative(int number)
        {
            var listFib = new List<int> { 0, 1};

            for (int i = 2; i <= number; i++)
            {
                listFib.Add(listFib[i - 1] + listFib[i - 2]);
            }

            return listFib[number];
        }

        public string ReverseStringRecursive(string str)
        {
            var reversedString = str.ToCharArray();
            ReverseStringRecursiveInternal(reversedString, 0, str.Length - 1);

            return new string(reversedString);
        }

        private void ReverseStringRecursiveInternal(char[] reversedString, int left, int right)
        {
            if (left >= right)
                return;
            else
            {
                var tmp = reversedString[left];
                reversedString[left] = reversedString[right];
                reversedString[right] = tmp;
                ReverseStringRecursiveInternal(reversedString, left + 1, right - 1);
            }
        }

        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return input;

            return ReverseString(input.Substring(1)) + input[0];
        }

    }
}
