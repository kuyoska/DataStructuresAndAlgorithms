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

        [Fact]
        public void ArraySliceShouldAddElementAtDesiredIndex()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1, 2,  4 };

            //act
            var result = bigO.ArraySplice(array, 2 , 3);

            //assert
            Assert.Equal([1, 2, 3, 4], result);
        }

        [Fact]
        public void ArraySliceShouldAddElementAtIndex0()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 2, 3, 4 };

            //act
            var result = bigO.ArraySplice(array, 0, 1);

            //assert
            Assert.Equal([1, 2, 3, 4], result);
        }

        [Fact]
        public void ArraySliceShouldAddElementAtTheEnd()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1, 2, 3 };

            //act
            var result = bigO.ArraySplice(array, 3, 4);

            //assert
            Assert.Equal([1, 2, 3, 4], result);
        }

        [Fact]
        public void ArraySlice2ShouldAddElementAtDesiredIndex()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1, 2, 4 };

            //act
            var result = bigO.ArraySplice2(array, 2, 3);

            //assert
            Assert.Equal([1, 2, 3, 4], result);
        }

        [Fact]
        public void ArraySlice2ShouldAddElementAtIndex0()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 2, 3, 4 };

            //act
            var result = bigO.ArraySplice2(array, 0, 1);

            //assert
            Assert.Equal([1, 2, 3, 4], result);
        }

        [Fact]
        public void ArraySlice2ShouldAddElementAtTheEnd()
        {
            //arrange
            var bigO = new BigO();
            var array = new int[] { 1, 2, 3 };

            //act
            var result = bigO.ArraySplice2(array, 3, 4);

            //assert
            Assert.Equal([1, 2, 3, 4], result);
        }
    }
}
