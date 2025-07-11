using CodeChallenges;

namespace CodeChallengesTesting
{
    public class MoreChallengesTests
    {
        [Fact]
        public void Compress_ShouldReturnCorrectLength()
        {
            // arrange
            var challenges = new MoreChallenges();
            char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };

            // act
            int result = challenges.Compress(chars);

            // assert
            Assert.Equal(6, result); // Expected compressed length is 6: "a2b2c3"
        }

        [Fact]
        public void Compress_ShouldReturnCorrectLength2()
        {
            // arrange
            var challenges = new MoreChallenges();
            char[] chars = { 'a' };

            // act
            int result = challenges.Compress(chars);

            // assert
            Assert.Equal(1, result); // Expected compressed length is 6: "a2b2c3"
        }

        [Fact]
        public void Compress_ShouldReturnCorrectLength3()
        {
            // arrange
            var challenges = new MoreChallenges();
            char[] chars = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };

            // act
            int result = challenges.Compress(chars);

            // assert
            Assert.Equal(4, result); // Expected compressed length is 6: "a2b2c3"
        }

        [Fact]
        public void FizzBuzz_ShouldReturnCorrectList()
        {
            // arrange
            var challenges = new MoreChallenges();
            int n = 15;
            // act
            var result = challenges.FizzBuzz(n);
            // assert
            Assert.Equal(15, result.Count);
            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
            Assert.Equal("Fizz", result[2]);
            Assert.Equal("4", result[3]);
            Assert.Equal("Buzz", result[4]);
            Assert.Equal("Fizz", result[5]);
            Assert.Equal("7", result[6]);
            Assert.Equal("8", result[7]);
            Assert.Equal("Fizz", result[8]);
            Assert.Equal("Buzz", result[9]);
            Assert.Equal("11", result[10]);
            Assert.Equal("Fizz", result[11]);
            Assert.Equal("13", result[12]);
            Assert.Equal("14", result[13]);
            Assert.Equal("FizzBuzz", result[14]);
        }

        [Fact]
        public void SingleNumber_ShouldReturnCorrectValue()
        {
            // arrange
            var challenges = new MoreChallenges();
            int[] nums = { 4, 1, 2, 1, 2 };

            // act
            int result = challenges.SingleNumber(nums);

            // assert
            Assert.Equal(4, result); // Expected single number is 4
        }

        [Fact]
        public void SingleNumberWithExtraSpace_ShouldReturnCorrectValue()
        {
            // arrange
            var challenges = new MoreChallenges();
            int[] nums = { 4, 1, 2, 1, 2 };

            // act
            int result = challenges.SingleNumberWithExtraSpace(nums);

            // assert
            Assert.Equal(4, result); // Expected single number is 4
        }

        [Fact]
        public void MaxDepth_ShouldReturnCorrectValue()
        {
            // arrange
            var challenges = new MoreChallenges();
            var root = new TreeNode(1)
            {
                Left = null,
                Right = new TreeNode(2)
            };

            // act
            int result = challenges.MaxDepth(root);

            // assert
            Assert.Equal(2, result); // Expected max depth is 2
        }

        [Fact]
        public void MaxDepth_ShouldReturnCorrectValue2()
        {
            // arrange
            var challenges = new MoreChallenges();
            var root = new TreeNode(3)
            {
                Left = new TreeNode(9),
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                }
            };

            // act
            int result = challenges.MaxDepth(root);

            // assert
            Assert.Equal(3, result); // Expected max depth is 2
        }
    }
}
