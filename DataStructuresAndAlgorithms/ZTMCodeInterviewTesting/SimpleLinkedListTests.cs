using ZTMCodeInterview.LinkedList;

namespace ZTMCodeInterviewTesting
{
    public class SimpleLinkedListTests
    {
        [Fact]
        public void AddToStartShouldWork()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);

            //assert
            Assert.Equal(1, sll.Count);
        }

        [Fact]
        public void AddToEndShouldWork()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToEnd(1);

            //assert
            Assert.Equal(1, sll.Count);
        }

        [Fact]
        public void AddToStartShouldReturn3()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);
            sll.AddToStart(2);
            sll.AddToStart(3);

            //assert
            Assert.Equal(3, sll.Count);
        }

        [Fact]
        public void AddToPositionShouldReturn4()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);
            sll.AddToEnd(2);
            sll.AddToEnd(3);
            sll.AddToPosition(4, 2);
            var array = sll.GetArray();

            //assert
            Assert.Equal(4, sll.Count);
            Assert.Equal([1,2, 4,3], array);
        }

        [Fact]
        public void AddToPositionShouldReturn7()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);
            sll.AddToEnd(2);
            sll.AddToEnd(3);
            sll.AddToEnd(4);
            sll.AddToEnd(5);
            sll.AddToEnd(6);
            sll.AddToPosition(10, 5);
            var array = sll.GetArray();

            //assert
            Assert.Equal(7, sll.Count);
            Assert.Equal([1, 2, 3, 4, 5, 10, 6], array);
        }

        [Fact]
        public void SearchShouldReturnTrueIfElementIsFound()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);
            sll.AddToEnd(2);
            sll.AddToEnd(3);
            var result = sll.Search(2);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void SearchShouldReturnFalseIfElementIsNotFound()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);
            sll.AddToEnd(2);
            sll.AddToEnd(3);
            var result = sll.Search(4);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveShouldWork()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);
            sll.AddToEnd(2);
            sll.AddToEnd(3);
            sll.AddToEnd(4);
            sll.Remove(3);
            var array = sll.GetArray();

            //assert
            Assert.Equal(3, sll.Count);
            Assert.Equal([1,2,4], array);
        }

        [Fact]
        public void ReverseShouldWork()
        {
            //arrange
            var sll = new SimpleLinkedList();

            //act
            sll.AddToStart(1);
            sll.AddToEnd(2);
            sll.AddToEnd(3);
            sll.AddToEnd(4);
            sll.Reverse();
            var array = sll.GetArray();

            //assert
            Assert.Equal(4, sll.Count);
            Assert.Equal([4, 3, 2, 1], array);
        }
    }
}
