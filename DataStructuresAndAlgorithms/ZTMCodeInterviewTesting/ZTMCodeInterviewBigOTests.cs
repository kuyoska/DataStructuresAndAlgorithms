using ZTMCodeInterview;

namespace ZTMCodeInterviewTesting
{
    public class ZTMCodeInterviewBigOTests
    {
        [Fact]
        public void ArrayPushShouldInsertNewElement()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1,2,3,4 };

            //act
            var result = bigO.ArrayPush(array, 5);

            //assert
            Assert.Equal([1,2,3,4,5], result);
        }

        [Fact]
        public void ArrayPopShouldRemoveLastElement()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1, 2, 3, 4 };

            //act
            var result = bigO.ArrayPop(array);

            //assert
            Assert.Equal([1, 2, 3], result);
        }

        [Fact]
        public void ArrayShiftShouldRemoveFirstElement()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1, 2, 3, 4 };

            //act
            var result = bigO.ArrayShift(array);

            //assert
            Assert.Equal([2, 3, 4], result);
        }

        [Fact]
        public void ArrayUnShiftShouldAddElementAtTheStart()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1, 2, 3, 4 };

            //act
            var result = bigO.ArrayUnShift(array, 5);

            //assert
            Assert.Equal([5, 1,2, 3, 4], result);
        }
    }
}
