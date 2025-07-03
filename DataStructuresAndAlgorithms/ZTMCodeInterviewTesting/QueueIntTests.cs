using ZTMCodeInterview.Queue;

namespace ZTMCodeInterviewTesting
{
    public class QueueIntTests
    {
        [Fact]
        public void EnqueueShouldWork()
        {
            //arrange
            var qu = new QueueInt();

            //act
            qu.Enqueue(1);
            var array = qu.GetArray();

            //assert
            Assert.Equal(1, qu.Count);
            Assert.Equal([1], array);
        }

        [Fact]
        public void EnqueueShouldWork2()
        {
            //arrange
            var qu = new QueueInt();

            //act
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            var array = qu.GetArray();

            //assert
            Assert.Equal(3, qu.Count);
            Assert.Equal([1, 2, 3], array);
        }

        [Fact]
        public void DequeueShouldWork()
        {
            //arrange
            var qu = new QueueInt();

            //act
            qu.Enqueue(1);
            qu.Enqueue(2);
            int value = qu.Dequeue();
            var array = qu.GetArray();

            //assert
            Assert.Equal(1, qu.Count);
            Assert.Equal(1, value);
            Assert.Equal([2], array);
        }

        [Fact]
        public void DequeueShouldThrowExceptionIfNoDataToDequeue()
        {
            //arrange
            var qu = new QueueInt();

            //assert
            Assert.Throws<Exception>(() =>
            {
                int value = qu.Dequeue();
            });
            Assert.Equal(0, qu.Count);
        }

        [Fact]
        public void PeekFrontShouldWork()
        {
            //arrange
            var qu = new QueueInt();

            //act
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            int value = qu.Peek(PeekDirection.Front);
            var array = qu.GetArray();

            //assert
            Assert.Equal(4, qu.Count);
            Assert.Equal(1, value);
            Assert.Equal([1, 2, 3, 4], array);
        }

        [Fact]
        public void PeekBackShouldWork()
        {
            //arrange
            var qu = new QueueInt();

            //act
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);
            int value = qu.Peek(PeekDirection.Back);
            var array = qu.GetArray();

            //assert
            Assert.Equal(4, qu.Count);
            Assert.Equal(4, value);
            Assert.Equal([1, 2, 3, 4], array);
        }
    }
}
