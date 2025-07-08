using ZTMCodeInterview.Recursion;

namespace ZTMCodeInterviewTesting
{
    public class RecursionTests
    {
        [Fact]
        public void FactorialRecursiveShouldWork()
        {
            //arrange
            var rs = new Recursion();

            //act
            var result = rs.Factorial(5);

            //assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void FactorialIterativeShouldWork()
        {
            //arrange
            var rs = new Recursion();

            //act
            var result = rs.FactorialIterative(5);

            //assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void FibonachiShouldWork()
        {
            //arrange
            var rs = new Recursion();

            //act
            var result = rs.Fibonachi(8);

            //assert
            Assert.Equal(21, result);
        }

        [Fact]
        public void FibonachiDPShouldWork()
        {
            //arrange
            var rs = new Recursion();

            //act
            var result = rs.FibonachiDP(8);

            //assert
            Assert.Equal(21, result);
        }

        [Fact]
        public void FibonachiIterativeShouldWork()
        {
            //arrange
            var rs = new Recursion();

            //act
            var result = rs.FibonachiIterative(8);

            //assert
            Assert.Equal(21, result);
        }

        [Fact]
        public void ReverseStringRecursiveShouldWork()
        {
            //arrange
            var rs = new Recursion();

            //act
            var result = rs.ReverseStringRecursive("carlos");

            //assert
            Assert.Equal("solrac", result);
        }

        [Fact]
        public void ReverseString2ShouldWork()
        {
            //arrange
            var rs = new Recursion();

            //act
            var result = rs.ReverseString("carlos");

            //assert
            Assert.Equal("solrac", result);
        }
    }
}
