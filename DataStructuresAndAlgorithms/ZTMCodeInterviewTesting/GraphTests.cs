using ZTMCodeInterview.Graph;

namespace ZTMCodeInterviewTesting
{
    public class GraphTests
    {
        [Fact]
        public void GraphAddVertexShouldWork()
        {
            //arrange
            var g = new Graph();

            //act
            g.AddVertex(0);

            //assert
            Assert.Equal(1, g.Count);
        }

        [Fact]
        public void GraphAddVertexShouldWork2()
        {
            //arrange
            var g = new Graph();

            //act
            g.AddVertex(0);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddVertex(3);
            g.AddVertex(4);
            g.AddVertex(5);
            g.AddVertex(6);

            //assert
            Assert.Equal(7, g.Count);
        }

        [Fact]
        public void GetStringRepresentationShouldWork()
        {
            //arrange
            var g = new Graph();

            //act
            g.AddVertex(0);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddVertex(3);
            g.AddVertex(4);
            g.AddVertex(5);
            g.AddVertex(6);
            var gRep = g.GetStringRepresentation();

            //assert
            Assert.Equal(7, g.Count);
            Assert.Equal("0->\r\n1->\r\n2->\r\n3->\r\n4->\r\n5->\r\n6->\r\n", gRep);
        }

        [Fact]
        public void AddEdgeShouldWork()
        {
            //arrange
            var g = new Graph();

            //act
            g.AddVertex(0);
            g.AddVertex(1);
            g.AddVertex(2);
            g.AddVertex(3);
            g.AddVertex(4);
            g.AddVertex(5);
            g.AddVertex(6);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 4);
            g.AddEdge(3, 4);
            g.AddEdge(4, 5);
            g.AddEdge(5, 6);


            var gRep = g.GetStringRepresentation();

            //assert
            Assert.Equal(7, g.Count);
            Assert.Equal("0->1 2 \r\n1->0 2 3 \r\n2->0 1 4 \r\n3->1 4 \r\n4->2 3 5 \r\n5->4 6 \r\n6->5 \r\n", gRep);
        }
    }
}
