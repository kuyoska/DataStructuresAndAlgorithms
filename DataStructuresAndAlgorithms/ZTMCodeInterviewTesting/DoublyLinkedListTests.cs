using ZTMCodeInterview.LinkedList;

namespace ZTMCodeInterviewTesting
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void DoublyLinkedListAddToStartShouldWork()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            var array = dll.GetArray();

            //assert
            Assert.Equal(1, dll.Count);
            Assert.Equal([1], array);
        }

        [Fact]
        public void DoublyLinkedListAddToStartShouldWork2()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToStart(2);
            var array = dll.GetArray();

            //assert
            Assert.Equal(2, dll.Count);
            Assert.Equal([2, 1], array);
        }

        [Fact]
        public void DoublyLinkedListAddToEndShouldWork1()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToEnd(2);
            dll.AddToEnd(3);
            var array = dll.GetArray();

            //assert
            Assert.Equal(3, dll.Count);
            Assert.Equal([1, 2, 3], array);
        }

        [Fact]
        public void DoublyLinkedListAddTopPositionShouldWork1()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToEnd(2);
            dll.AddToEnd(3);
            dll.AddToPosition(4, 2);
            var array = dll.GetArray();

            //assert
            Assert.Equal(4, dll.Count);
            Assert.Equal([1, 2, 4, 3], array);
        }

        [Fact]
        public void DoublyLinkedListAddTopPositionShouldWork2()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToEnd(2);
            dll.AddToEnd(3);
            dll.AddToEnd(4);
            dll.AddToEnd(5);
            dll.AddToEnd(6);
            dll.AddToPosition(10, 5);
            var array = dll.GetArray();

            //assert
            Assert.Equal(7, dll.Count);
            Assert.Equal([1, 2, 3, 4, 5, 10, 6], array);
        }

        [Fact]
        public void SearchShouldReturnTrueIfElementIsFound()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToEnd(2);
            dll.AddToEnd(3);
            var result = dll.Search(2);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void SearchShouldReturnFalseIfElementIsNotFound()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToEnd(2);
            dll.AddToEnd(3);
            var result = dll.Search(4);

            //assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveShouldWork()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToEnd(2);
            dll.AddToEnd(3);
            dll.AddToEnd(4);
            dll.Remove(3);
            var array = dll.GetArray();

            //assert
            Assert.Equal(3, dll.Count);
            Assert.Equal([1, 2, 4], array);
        }

        [Fact]
        public void ReverseShouldWork()
        {
            //arrange
            var dll = new DoublyLinkedList();

            //act
            dll.AddToStart(1);
            dll.AddToEnd(2);
            dll.AddToEnd(3);
            dll.AddToEnd(4);
            var array = dll.GetArrayReverse();

            //assert
            Assert.Equal(4, dll.Count);
            Assert.Equal([4, 3, 2, 1], array);
        }
    }
}
