using System.Text;

namespace ZTMCodeInterview.Graph
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjacentList;

        public int Count { get { return adjacentList.Count; } }

        public Graph()
        {
            adjacentList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int node)
        {
            if (!adjacentList.ContainsKey(node))
            {
                adjacentList[node] = new List<int>();
            }
        }

        public void AddEdge(int node1, int node2)
        {
            var _vertex = adjacentList[node1];

            if (_vertex != null)
            {
                _vertex.Add(node2);
            }

            _vertex = adjacentList[node2];

            if (_vertex != null)
            {
                _vertex.Add(node1);
            }
        }

        public string GetStringRepresentation()
        {
            var sb = new StringBuilder();

            foreach(var vertex in adjacentList.Keys)
            {
                sb.Append($"{vertex}->");

                foreach(var edge in adjacentList[vertex])
                {
                    sb.Append($"{edge.ToString()} ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
