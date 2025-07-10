using CodeChallenges;

namespace CodeChallengesTesting
{
    public class EAChallengesTests
    {
        [Fact]
        public void CalculateSumOfDigits_ShouldReturnCorrectSum()
        {
            // arrange
            var challenges = new EAChallenges();
            int fourDigitInt = 1234;

            // act
            int result = challenges.CalculateSumOfDigits(fourDigitInt);

            // assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void CalculateSumOfDigitsUsingString_ShouldReturnCorrectSum()
        {
            // arrange
            var challenges = new EAChallenges();
            int fourDigitInt = 5678;

            // act
            int result = challenges.CalculateSumOfDigitsUsingString(fourDigitInt);

            // assert
            Assert.Equal(26, result);
        }

        [Fact]
        public void ComputeClosesToZero_ShouldReturnClosestToZero()
        {
            // arrange
            var challenges = new EAChallenges();
            int[] numbers = { 3, -2, 1, -5, 4 };

            // act
            int result = challenges.ComputeClosesToZero(numbers);

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void IsDuoDigit_ShouldReturnCorrectResult()
        {
            // arrange
            var challenges = new EAChallenges();
            int number = 121;
            
            // act
            string result = challenges.IsDuoDigit(number);

            // assert
            Assert.Equal("yes", result);
        }

        [Fact]
        public void IsDuoDigit_ShouldReturnCorrectResultWhenNotDuoDigit()
        {
            // arrange
            var challenges = new EAChallenges();
            int number = 102;

            // act
            string result = challenges.IsDuoDigit(number);

            // assert
            Assert.Equal("no", result);
        }

        [Fact]
        public void IsDuoDigit_ShouldReturnYesForNegativeDuoDigit()
        {
            // arrange
            var challenges = new EAChallenges();
            int number = -33;
            // act
            string result = challenges.IsDuoDigit(number);
            // assert
            Assert.Equal("yes", result);
        }

        [Fact]
        public void IsDuoDigit_ShouldReturnNoForNegativeNonDuoDigit()
        {
            // arrange
            var challenges = new EAChallenges();
            int number = -123;
            // act
            string result = challenges.IsDuoDigit(number);
            // assert
            Assert.Equal("no", result);
        }

        [Fact]
        public void Reshape_ShouldWordsWithValidInput()
        {
            // arrange
            var challenges = new EAChallenges();
            string input = "Hello World! This is a test string.";
            int n = 5;

            // act
            string result = challenges.Reshape(n, input);

            // assert
            Assert.Equal("Hello\r\nWorl\r\nd!Th\r\nisis\r\nate\r\nstst\r\nring.\r\n", result);
        }
    }
}
