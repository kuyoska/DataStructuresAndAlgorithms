using System.Xml.Linq;

namespace ZTMCodeInterview.Searching
{
    public class BreadthFirstSearch
    {
        public List<int> BreathFirstSearch(Node currentNode)
        {
            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.value);
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
            return list;
        }

        public static List<int> BreathFirstSearchR(Queue<Node> queue, List<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }

            var currentNode = queue.Dequeue();
            list.Add(currentNode.value);
            if (currentNode.left != null)
            {
                queue.Enqueue(currentNode.left);
            }

            if (currentNode.right != null)
            {
                queue.Enqueue(currentNode.right);
            }

            return BreathFirstSearchR(queue, list);
        }
    }

    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }
        public int value { get; set; }

        public Node(int value)
        {
            this.left = null;
            this.right = null;
            this.value = value;
        }
    }
}
