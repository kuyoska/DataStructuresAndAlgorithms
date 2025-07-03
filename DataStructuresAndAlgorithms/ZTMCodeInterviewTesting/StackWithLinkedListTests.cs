using ZTMCodeInterview.Stack;

namespace ZTMCodeInterviewTesting
{
    public class StackWithLinkedListTests
    {
        [Fact]
        public void PushShouldWork()
        {
            //arrange
            var stack = new StackWithLinkedList();

            //act
            stack.Push(1);
            var array = stack.GetArray();

            //assert
            Assert.Equal(1, stack.Count);
            Assert.Equal([1], array);
        }

        [Fact]
        public void PushShouldWork2()
        {
            //arrange
            var stack = new StackWithLinkedList();

            //act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var array = stack.GetArray();

            //assert
            Assert.Equal(3, stack.Count);
            Assert.Equal([3, 2, 1], array);
        }

        [Fact]
        public void PopShouldWork()
        {
            //arrange
            var stack = new StackWithLinkedList();

            //act
            stack.Push(1);
            stack.Push(2);
            int value = stack.Pop();
            var array = stack.GetArray();

            //assert
            Assert.Equal(1, stack.Count);
            Assert.Equal(2, value);
            Assert.Equal([1], array);
        }

        [Fact]
        public void PopShouldThrowExceptionIfNoDataToDequeue()
        {
            //arrange
            var stack = new StackWithLinkedList();

            //assert
            Assert.Throws<Exception>(() =>
            {
                int value = stack.Pop();
            });
            Assert.Equal(0, stack.Count);
        }

        [Fact]
        public void PeekShouldWork()
        {
            //arrange
            var stack = new StackWithLinkedList();

            //act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            int value = stack.Peek();
            var array = stack.GetArray();

            //assert
            Assert.Equal(4, stack.Count);
            Assert.Equal(4, value);
            Assert.Equal([4, 3, 2, 1], array);
        }
    }
}
