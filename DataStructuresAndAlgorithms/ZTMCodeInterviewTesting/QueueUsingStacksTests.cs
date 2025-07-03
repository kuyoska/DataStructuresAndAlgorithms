using ZTMCodeInterview.Queue;

namespace ZTMCodeInterviewTesting
{
    public class QueueUsingStacksTests
    {
        [Fact]
        public void PushShouldWork()
        {
            //arrange
            var qu = new QueueUsingStacks();

            //act
            qu.Push(1);

            //arrange
            Assert.Equal(1, qu.Count);
        }

        [Fact]
        public void PeekShouldWork()
        {
            //arrange
            var qu = new QueueUsingStacks();

            //act
            qu.Push(1);
            var value = qu.Peek();

            //arrange
            Assert.Equal(1, qu.Count);
            Assert.Equal(1, value);
        }

        [Fact]
        public void PeekShouldWork2()
        {
            //arrange
            var qu = new QueueUsingStacks();

            //act
            qu.Push(1);
            qu.Push(2);
            var value = qu.Peek();

            //arrange
            Assert.Equal(2, qu.Count);
            Assert.Equal(1, value);
        }

        [Fact]
        public void PeekShouldWork3()
        {
            //arrange
            var qu = new QueueUsingStacks();

            //act
            qu.Push(1);
            qu.Push(2);
            qu.Push(3);
            var value = qu.Peek();

            //arrange
            Assert.Equal(3, qu.Count);
            Assert.Equal(1, value);
        }

        [Fact]
        public void PopShouldWork()
        {
            //arrange
            var qu = new QueueUsingStacks();

            //act
            qu.Push(1);
            qu.Push(2);
            qu.Push(3);
            var value = qu.Pop();

            //arrange
            Assert.Equal(2, qu.Count);
            Assert.Equal(1, value);
        }

        [Fact]
        public void EmptyShouldReturnFalse()
        {
            //arrange
            var qu = new QueueUsingStacks();

            //act
            qu.Push(1);
            qu.Push(2);
            qu.Push(3);
            var value = qu.Pop();
            var isEmpty = qu.Empty();

            //arrange
            Assert.Equal(2, qu.Count);
            Assert.Equal(1, value);
            Assert.False(isEmpty);
        }

        [Fact]
        public void EmptyShouldReturnTrue()
        {
            //arrange
            var qu = new QueueUsingStacks();

            //act
            qu.Push(1);
            qu.Push(2);
            qu.Push(3);
            var value = qu.Pop();
            value = qu.Pop();
            value = qu.Pop();
            var isEmpty = qu.Empty();

            //arrange
            Assert.Equal(0, qu.Count);
            Assert.Equal(3, value);
            Assert.True(isEmpty);
        }
    }
}
