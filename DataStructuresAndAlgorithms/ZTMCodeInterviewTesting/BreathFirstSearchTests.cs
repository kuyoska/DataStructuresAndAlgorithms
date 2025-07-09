using ZTMCodeInterview.Searching;

namespace ZTMCodeInterviewTesting
{
    public class BreathFirstSearchTests
    {
        [Fact]
        public void BreathFirstSearch_ShouldReturnCorrectOrder()
        {
            // arrange
            var bfs = new BreadthFirstSearch();
            var root = new Node(1)
            {
                left = new Node(2)
                {
                    left = new Node(4),
                    right = new Node(5)
                },
                right = new Node(3)
                {
                    left = new Node(6),
                    right = new Node(7)
                }
            };

            // act
            var result = bfs.BreathFirstSearch(root);

            // assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7 }, result);
        }

        [Fact]
        public void BreathFirstSearchR_ShouldReturnCorrectOrder()
        {
            // arrange
            var bfs = new BreadthFirstSearch();
            var root = new Node(1)
            {
                left = new Node(2)
                {
                    left = new Node(4),
                    right = new Node(5)
                },
                right = new Node(3)
                {
                    left = new Node(6),
                    right = new Node(7)
                }
            };
            var queue = new Queue<Node>();
            queue.Enqueue(root);
            var list = new List<int>();

            // act
            var result = BreadthFirstSearch.BreathFirstSearchR(queue, list);

            // assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7 }, result);
        }
    }
}
