using ZTMCodeInterview.Sorting;

namespace ZTMCodeInterviewTesting
{
    public class SortingTests
    {
        [Fact]
        public void BubbleSort_ShouldWork()
        {
            // arrange
            var sorting = new Sorting();
            int[] array = [12, 99, 3, 1, 43, 2];

            // act
            sorting.BubbleSort(array);

            // assert
            Assert.Equal([1, 2, 3, 12, 43, 99], array);
        }

        [Fact]
        public void SelectionSort_ShouldWork()
        {
            // arrange
            var sorting = new Sorting();
            int[] array = [12, 99, 3, 1, 43, 2];

            // act
            sorting.SelectionSort(array);

            // assert
            Assert.Equal([1, 2, 3, 12, 43, 99], array);
        }

        [Fact]
        public void InsertionSort_ShouldWork()
        {
            // arrange
            var sorting = new Sorting();
            int[] array = [12, 99, 3, 1, 43, 2];

            // act
            sorting.InsertionSort(array);

            // assert
            Assert.Equal([1, 2, 3, 12, 43, 99], array);
        }

        [Fact]
        public void MergeSort_ShouldWork()
        {
            // arrange
            var sorting = new Sorting();
            int[] array = [12, 99, 3, 1, 43, 2];

            // act
            sorting.MergeSort(array);

            // assert
            Assert.Equal([1, 2, 3, 12, 43, 99], array);
        }

        [Fact]
        public void QuickSort_ShouldWork()
        {
            // arrange
            var sorting = new Sorting();
            int[] array = [12, 99, 3, 1, 43, 2];

            // act
            sorting.QuickSort(array);

            // assert
            Assert.Equal([1, 2, 3, 12, 43, 99], array);
        }
    }
}
