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

        [Fact]
        public void ReverseStringShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();

            //act
            var result = ap.ReverseString("carlos");

            //assert
            Assert.Equal("solrac",result);
        }

        [Fact]
        public void MergeTwoSortedArraysShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array1 = [0, 3, 4, 31];
            int[] array2 = [4, 6, 30];

            //act
            var result = ap.MergeSortedArrays(array1, array2);

            //assert
            Assert.Equal([0, 3, 4, 4, 6, 30, 31], result);
        }

        [Fact]
        public void TwoSumShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [2, 7, 11, 15];

            //act
            var result = ap.TwoSum(array, 9);

            //assert
            Assert.Equal([0, 1], result);
        }

        [Fact]
        public void TwoSumBruteForceShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [2, 5, 5, 11];

            //act
            var result = ap.TwoSumBruteForce(array, 10);

            //assert
            Assert.Equal([1, 2], result);
        }

        [Fact]
        public void MaxSubArrayShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [-2, 1, -3, 4, -1, 2, 1, -5, 4];

            //act
            var result = ap.MaxSubArray(array);

            //assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void MoveZeroesShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [0, 1, 0, 3, 12];

            //act
            var result = ap.MoveZeroes(array);

            //assert
            Assert.Equal([1, 3, 12, 0, 0], result);
        }

        [Fact]
        public void MoveZeroesNotAdditionalSpaceShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [0, 1, 0, 3, 12];

            //act
            var result = ap.MoveZeroesNoAdditionalSpace(array);

            //assert
            Assert.Equal([1, 3, 12, 0, 0], result);
        }

        [Fact]
        public void MoveZeroesNotAdditionalSpaceShouldWork2()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 0];

            //act
            var result = ap.MoveZeroesNoAdditionalSpace(array);

            //assert
            Assert.Equal([1, 0], result);
        }

        [Fact]
        public void MoveZeroesNotAdditionalSpaceShouldWork3()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 0 , 1];

            //act
            var result = ap.MoveZeroesNoAdditionalSpace(array);

            //assert
            Assert.Equal([1, 1, 0], result);
        }

        [Fact]
        public void MoveZeroesNotSoEfficientShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 0, 1];

            //act
            var result = ap.MoveZeroesNotSoEfficient(array);

            //assert
            Assert.Equal([1, 1, 0], result);
        }

        [Fact]
        public void MoveZeroesNotSoEfficientShouldWork2()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [0, 1, 0, 3, 12];

            //act
            var result = ap.MoveZeroesNotSoEfficient(array);

            //assert
            Assert.Equal([1, 3, 12, 0, 0], result);
        }

        [Fact]
        public void ContainsDuplicateShouldReturnTrueWhenDuplicates()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 2, 3, 1];

            //act
            var result = ap.ContainsDuplicate(array);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void ContainsDuplicateShouldReturnFalseWhenNoDuplicates()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 2, 3, 4];

            //act
            var result = ap.ContainsDuplicate(array);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void LongestWordShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();

            //act
            var result = ap.LongestWord("fun&!! time");

            //assert
            Assert.Equal("time", result);
        }

        [Fact]
        public void LongestWordShouldWork2()
        {
            //arrange
            var ap = new ArraysProblems();

            //act
            var result = ap.LongestWord("I love dogs");

            //assert
            Assert.Equal("love", result);
        }

        [Fact]
        public void RotateShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 2, 3, 4, 5, 6, 7];

            //act
            var result = ap.Rotate(array, 3);

            //assert
            Assert.Equal([5, 6, 7, 1, 2, 3, 4], result);
        }

        [Fact]
        public void RotateWithReversingShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 2, 3, 4, 5, 6, 7];

            //act
            var result = ap.RotateWithReversing(array, 3);

            //assert
            Assert.Equal([5, 6, 7, 1, 2, 3, 4], result);
        }

        [Fact]
        public void RotateWithExtraSpaceShouldWork()
        {
            //arrange
            var ap = new ArraysProblems();
            int[] array = [1, 2, 3, 4, 5, 6, 7];

            //act
            var result = ap.RotateWithExtraSpace(array, 3);

            //assert
            Assert.Equal([5, 6, 7, 1, 2, 3, 4], result);
        }
    }
}
