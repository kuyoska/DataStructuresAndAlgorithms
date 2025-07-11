namespace ZTMCodeInterview.DynamicPrograming
{
    public class DP
    {
        public Func<int, int> MemoizedAddTo80()
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            // This function returns a function that takes an integer n and returns n + 80,
            return n =>
            {
                if(memo.ContainsKey(n))
                    return memo[n];
                else
                {
                    memo[n] = n + 80;
                    return memo[n];
                }
            };
        }

        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }

        public Func<int, int> FibonacciMemoized()
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            // This function returns a function that takes an integer n and returns the nth Fibonacci number using memoization
            return n =>
            {
                if (memo.ContainsKey(n))
                    return memo[n];
                else
                {
                    if(n <= 1)
                        return n;
                    else
                        memo[n] = FibonacciMemoized()(n - 1) + FibonacciMemoized()(n - 2);
                    return memo[n];
                }
            };
        }
    }
}
