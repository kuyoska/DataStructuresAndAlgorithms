namespace ZTMCodeInterview.Tree
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; private set; }
        public int Count { get; private set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode { Value = value };
            }
            else
            {
                var currentNode = Root;

                while (currentNode != null)
                {
                    if (currentNode.Value > value )
                    {
                        if(currentNode.Left == null)
                        {
                            currentNode.Left = new BinarySearchTreeNode { Value = value };
                            break;
                        }                            
                        currentNode = currentNode.Left;
                    }
                    else if (currentNode.Value < value )
                    {
                        if(currentNode.Right == null)
                        {
                            currentNode.Right = new BinarySearchTreeNode { Value = value };
                            break;
                        }                        
                        currentNode = currentNode.Right;
                    }
                }
            }

            Count++;
        }

        public bool LookUp(int value)
        {
            var currentNode = Root;

            while (currentNode != null)
            {
                if(currentNode.Value == value)
                    return true;

                if (currentNode.Value > value)
                {
                   currentNode = currentNode.Left;
                }
                else if (currentNode.Value < value)
                {
                    currentNode = currentNode.Right;
                }
            }

            return false;
        }

        public (BinarySearchTreeNode found, BinarySearchTreeNode parent) LookUpWithParent(int value)
        {
            var currentNode = Root;
            BinarySearchTreeNode parentNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                    return (currentNode, parentNode);

                parentNode = currentNode;

                if (currentNode.Value > value)
                {
                    currentNode = currentNode.Left;
                }
                else if (currentNode.Value < value)
                {
                    currentNode = currentNode.Right;
                }
            }

            return (null,null);
        }

        public void Remove(int value)
        {
            var (nodeToDelete, parent) = LookUpWithParent(value);

            if(nodeToDelete != null)
            {
                if (nodeToDelete.IsLeaf)
                {
                    if (nodeToDelete.Value > parent.Value)
                        parent.Right = null;
                    else
                        parent.Left = null;

                    nodeToDelete = null;
                    Count--;
                    return;
                }
                //case 1: If the node being deleted has no right child, then the node's left child can be used as the replacement
                if(nodeToDelete.Right == null)
                {
                    if (parent == null)//we wanto to delete the root
                        Root = nodeToDelete.Left;
                    else
                    {
                        if (nodeToDelete.Left.Value > parent.Value)
                            parent.Right = nodeToDelete.Left;
                        else
                            parent.Left = nodeToDelete.Left;                        
                    }

                    nodeToDelete = null;
                    Count--;
                    return;
                }
                //case 2: If the deleted node's right child has no left child, then the deleted node's right child can replace the deleted node
                if(nodeToDelete.Right.Left == null)
                {
                    if (parent == null)
                        Root = nodeToDelete.Right;
                    else
                    {
                        nodeToDelete.Right.Left = nodeToDelete.Left;
                        if (nodeToDelete.Right.Value > parent.Value)
                            parent.Right = nodeToDelete.Right;
                        else
                            parent.Left = nodeToDelete.Left;
                    }
                    nodeToDelete = null;
                    Count--;
                    return;
                }
                //case 3: if the deleted node's right child does have a left child, then the deleted node needs to be replaced by the deleted node's right child's left-most descendant
                if (nodeToDelete.Right.Left != null)
                {
                    BinarySearchTreeNode successor = null;
                    BinarySearchTreeNode successorParent = nodeToDelete.Right;

                    var currentNode = nodeToDelete.Right.Left;

                    while(currentNode != null)
                    {
                        if (currentNode.IsLeaf)
                        {
                            successor = currentNode;
                            break;
                        }                            
                        else
                        {
                            successorParent = currentNode;
                            currentNode = currentNode.Left;
                        }                            
                    }

                    successor.Left = nodeToDelete.Left;
                    successor.Right = nodeToDelete.Right;
                    successorParent.Left = null;

                    if (parent == null)
                        Root = successor;
                    else
                    {
                        if (successor.Value > parent.Value)
                            parent.Right = successor;
                        else
                            parent.Left = successor;
                    } 
                    nodeToDelete = null;
                    Count--;
                    return;
                }                
            }
        }

        public List<int> ToList()
        {
            var list = new List<int>();

            InternalToArray(Root, list);

            return list;
        }

        private void InternalToArray(BinarySearchTreeNode node, List<int> list)
        {
            if (node == null) return;
            list.Add(node.Value);
            if (node.Left == null && node.Right == null)
            {                
                return;
            }            
            InternalToArray(node.Left, list);
            InternalToArray(node.Right, list);
        }
    }

    public class BinarySearchTreeNode
    {
        public int Value { get; set; }
        public BinarySearchTreeNode Left { get; set; }
        public BinarySearchTreeNode Right { get; set; }

        public bool IsLeaf { get { return Left == null && Right == null; } }
    }
}
 