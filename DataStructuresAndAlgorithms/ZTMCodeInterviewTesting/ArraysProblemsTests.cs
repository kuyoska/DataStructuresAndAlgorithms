using ZTMCodeInterview;

namespace ZTMCodeInterviewTesting
{
    public class ArraysProblemsTests
    {
        [Fact]
        public void ArrayContainsCommonItemShouldReturnTrueWhenItemInBothArrays()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array1 = [1, 2, 3, 4];
            int[] array2 = [5, 3, 9];

            //act
            var result = ap.ArraysContainCommonItem(array1, array2);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void ArrayContainsCommonItemShouldReturnFalseWhenNoItemInBothArrays()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array1 = [1, 2, 3, 4];
            int[] array2 = [5, 0, 9];

            //act
            var result = ap.ArraysContainCommonItem(array1, array2);

            //assert
            Assert.False(result);
        }
    }
}
