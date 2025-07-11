using ZTMCodeInterview.DynamicPrograming;

namespace ZTMCodeInterviewTesting
{
    public class DPTests
    {
        [Fact]
        public void MemoizedAddTo80_ShouldReturnCorrectValue()
        {
            //arrange
            var dp = new DP();

            //act
            var addTo80 = dp.MemoizedAddTo80();

            //assert
            Assert.Equal(80, addTo80(0));
            Assert.Equal(80, addTo80(0));
            Assert.Equal(100, addTo80(20));
            Assert.Equal(160, addTo80(80));
            Assert.Equal(200, addTo80(120));
        }

        [Fact]
        public void Fibonacci_ShouldReturnCorrectValue()
        {
            //arrange
            var dp = new DP();
            //act & assert
            Assert.Equal(0, dp.Fibonacci(0));
            Assert.Equal(1, dp.Fibonacci(1));
            Assert.Equal(1, dp.Fibonacci(2));
            Assert.Equal(2, dp.Fibonacci(3));
            Assert.Equal(3, dp.Fibonacci(4));
            Assert.Equal(5, dp.Fibonacci(5));
            Assert.Equal(8, dp.Fibonacci(6));
            Assert.Equal(13, dp.Fibonacci(7));
            Assert.Equal(21, dp.Fibonacci(8));
            Assert.Equal(34, dp.Fibonacci(9));
        }

        [Fact]
        public void FibonacciMemoized_ShouldReturnCorrectValue()
        {
            //arrange
            var dp = new DP();
            var fibonacciMemoized = dp.FibonacciMemoized();
            //act & assert
            Assert.Equal(0, fibonacciMemoized(0));
            Assert.Equal(1, fibonacciMemoized(1));
            Assert.Equal(1, fibonacciMemoized(2));
            Assert.Equal(2, fibonacciMemoized(3));
            Assert.Equal(3, fibonacciMemoized(4));
            Assert.Equal(5, fibonacciMemoized(5));
            Assert.Equal(8, fibonacciMemoized(6));
            Assert.Equal(13, fibonacciMemoized(7));
            Assert.Equal(21, fibonacciMemoized(8));
            Assert.Equal(34, fibonacciMemoized(9));
        }
    }
}
