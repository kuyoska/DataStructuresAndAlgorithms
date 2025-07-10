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
    }
}
