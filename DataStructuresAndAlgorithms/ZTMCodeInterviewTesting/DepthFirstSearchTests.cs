using ZTMCodeInterview.Searching;

namespace ZTMCodeInterviewTesting
{
    public class DepthFirstSearchTests
    {
        [Fact]
        public void DPSInOrder_ShouldReturnCorrectOrder()
        {
            // arrange
            var dfs = new DepthFirstSearch();
            var root = new Node(4)
            {
                left = new Node(2)
                {
                    left = new Node(1),
                    right = new Node(3)
                },
                right = new Node(6)
                {
                    left = new Node(5),
                    right = new Node(7)
                }
            };

            // act
            var result = dfs.DPSInOrder(root);

            // assert
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7 }, result);
        }

        [Fact]
        public void DPSPostOrder_ShouldReturnCorrectOrder()
        {
            // arrange
            var dfs = new DepthFirstSearch();
            var root = new Node(4)
            {
                left = new Node(2)
                {
                    left = new Node(1),
                    right = new Node(3)
                },
                right = new Node(6)
                {
                    left = new Node(5),
                    right = new Node(7)
                }
            };
            // act
            var result = dfs.DPSPostOrder(root);
            // assert
            Assert.Equal(new List<int> { 1, 3, 2, 5, 7, 6, 4 }, result);
        }

        [Fact]
        public void DPSPreOrder_ShouldReturnCorrectOrder()
        {
            // arrange
            var dfs = new DepthFirstSearch();
            var root = new Node(4)
            {
                left = new Node(2)
                {
                    left = new Node(1),
                    right = new Node(3)
                },
                right = new Node(6)
                {
                    left = new Node(5),
                    right = new Node(7)
                }
            };
            // act
            var result = dfs.DPSPreOrder(root);
            // assert
            Assert.Equal(new List<int> { 4, 2, 1, 3, 6, 5, 7 }, result);
        }
    }
}
