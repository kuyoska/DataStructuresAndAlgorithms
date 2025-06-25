using AlgorithmicThinking;

namespace AlgorithmicThinkingTesting
{
    public class AlgorithmicThinkingTests
    {
        [Fact]
        public void TwoHigherOperatosInSameExpressionShouldPerformFromLeftToRight()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.TwoHigherOperatorsInSameExpression();

            //assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void SquareRootOf64UsingMathPowShouldBe8()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.SquareRootUsingPOW(64);

            //assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void CubicRootOf512UsingMathPowShouldBe8()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.CubicRootUsingPOW(512);

            //assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void SumOfDigitsFor6541ShouldBe16FirstApproach()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.SumOfDigitsOf4DigitsIntFirstApproach(6541);

            //assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void SumOfDigitsFor6541ShouldBe16SecondApproach()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.SumOfDigitsOf4DigitsIntSecondApproach(6541);

            //assert
            Assert.Equal(16, result);
        }

        [Fact]
        public void ElapsedTimeInSecondsShouldDisplayCorrectStringFirstApproach()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.ElapsedSecondsToTimeFirstApproach(700005);

            //assert
            Assert.Equal("8 day(s) 2 hour(s) 26 minute(s) and 45 second(s)", result);
        }

        [Fact]
        public void ElapsedTimeInSecondsShouldDisplayCorrectStringSecondApproach()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.ElapsedSecondsToTimeSecondApproach(700005);

            //assert
            Assert.Equal("8 day(s) 2 hour(s) 26 minute(s) and 45 second(s)", result);
        }

        [Fact]
        public void ReverseThreeDigitNumber541ShouldBe145()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.ReversedThreeDigitNumber(541);

            //assert
            Assert.Equal(145, result);
        }

        [Fact]
        public void ProgressiveRatesFor2200ShouldReturn505()
        {
            //arrange
            var atLibrary = new ATLibrary();

            //act
            var result = atLibrary.ProgressiveRates(2200);

            //assert
            Assert.Equal(505, result);
        }

        [Fact]
        public void BubbleSortShouldWork()
        {
            //arrange
            var atLibrary = new ATLibrary();
            var array = new int[] { 17, 25, 8 , 5, 49, 12, 50 , 1 , 74,  22, 3 };

            //act
            atLibrary.BubbleSort(array);

            //assert
            Assert.Equal([1, 3, 5, 8, 12, 17, 22, 25, 49, 50, 74], array);
        }

        [Fact]
        public void SelectionSortShouldWork()
        {
            //arrange
            var atLibrary = new ATLibrary();
            var array = new int[] { 18, 19, 39, 36, 4, 9 };

            //act
            atLibrary.SelectionSort(array);

            //assert
            Assert.Equal([4, 9, 18, 19, 36, 39], array);
        }

        [Fact]
        public void InsertionSortShouldWork()
        {
            //arrange
            var atLibrary = new ATLibrary();
            var array = new int[] { 3, 15, 24, 8, 10, 18, 9 };

            //act
            atLibrary.InsertionSort(array);

            //assert
            Assert.Equal([3, 8, 9, 10, 15, 18, 24], array);
        }

        [Fact]
        public void BinarySearchShouldFindElement()
        {
            //arrange
            var atLibrary = new ATLibrary();
            int[] sortedArray = [12, 15, 19, 24, 28, 31, 39, 41, 44, 53, 57, 59, 62, 64];

            //act
            var result = atLibrary.BinarySearch(sortedArray, 44);

            //assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void BinarySearchShouldReturnMenusOneIfNotFoundElement()
        {
            //arrange
            var atLibrary = new ATLibrary();
            int[] sortedArray = [12, 15, 19, 24, 28, 31, 39, 41, 44, 53, 57, 59, 62, 64];

            //act
            var result = atLibrary.BinarySearch(sortedArray, 100);

            //assert
            Assert.Equal(-1, result);
        }
    }
}
