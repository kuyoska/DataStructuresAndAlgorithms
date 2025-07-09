

using System.Collections.Generic;
using System.Xml.Linq;

namespace ZTMCodeInterview.Searching
{
    public class DepthFirstSearch
    {
        public List<int> DPSInOrder(Node currentNode)
        {
            List<int> result = new List<int>();
            TraverseInOrder(currentNode, result);
            return result;
        }

        private void TraverseInOrder(Node node, List<int> list)
        {
            if (node.left != null)
            {
                TraverseInOrder(node.left, list);
            }
            list.Add(node.value);
            if (node.right != null)
            {
                TraverseInOrder(node.right, list);
            }
        }

        public List<int> DPSPostOrder(Node currentNode)
        {
            List<int> result = new List<int>();
            TraversePostOrder(currentNode, result);
            return result;
        }

        private void TraversePostOrder(Node node, List<int> list)
        {            
            if (node.left != null)
            {
                TraversePostOrder(node.left, list);
            }

            if (node.right != null)
            {
                TraversePostOrder(node.right, list);
            }
            list.Add(node.value);
        }

        public List<int> DPSPreOrder(Node currentNode)
        {
            List<int> result = new List<int>();
            TraversePreOrder(currentNode, result);
            return result;
        }

        private void TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.value);
            if (node.left != null)
            {
                TraversePreOrder(node.left, list);
            }

            if (node.right != null)
            {
                TraversePreOrder(node.right, list);
            }
        }
    }
}
