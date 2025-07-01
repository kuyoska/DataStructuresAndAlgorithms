namespace ZTMCodeInterview.LinkedList
{
    public class DoublyLinkedList
    {
        private DoublyLinkedNode _head;
        private DoublyLinkedNode _tail;
        private int _count = 0;

        public int Count { get { return _count; } }

        public void AddToStart(int value)
        {
            var newHead = new DoublyLinkedNode { Value = value };

            if (_head == null)
            {
                _head = newHead;
                _tail = newHead;
            }
            else
            {
                newHead.Next = _head;
                _head.Previous = newHead;
                _head = newHead;
            }

            _count++;
        }

        public void AddToEnd(int value)
        {
            if (_count == 0)
                AddToStart(value);
            else
            {
                var newTail = new DoublyLinkedNode { Value = value };
                newTail.Previous = _tail;
                _tail.Next = newTail;
                _tail = newTail;

                _count++;
            }
        }

        public void AddToPosition(int value, int position)
        {
            if (position <= 0 || position > _count)
                return;

            if (position == 1)
            {
                AddToStart(value);
                return;
            }
            if (position == _count)
            {
                AddToEnd(value);
                return;
            }

            var currentNode = _head;

            var newNode = new DoublyLinkedNode { Value = value };

            for (int i = 1; i <= position; i++)
            {
                if (i == position)
                {
                    newNode.Previous = currentNode;
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                }
                else currentNode = currentNode.Next;
            }

            _count++;
        }

        public bool Search(int value)
        {
            var currentNode = _head;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                    return true;
                else currentNode = currentNode.Next;
            }

            return false;
        }

        public void Remove(int position)
        {
            if (position == 1)
            {
                var currentHead = _head;
                _head = currentHead.Next;
                _head.Previous = null;
                currentHead = null;
            }
            else
            {
                var currentNode = _head;

                for (int i = 1; i <= position; i++)
                {
                    if (i == position)
                    {
                        var previousNode = currentNode.Previous;
                        previousNode.Next = currentNode.Next;
                        previousNode.Next.Previous = previousNode;
                        currentNode = null;
                        _count--;
                        return;
                    }
                    else currentNode = currentNode.Next;
                }
            }
        }

        public int[] GetArray()
        {
            int[] array = new int[_count];
            int count = 0;

            var currentNode = _head;
            while (currentNode != null)
            {
                array[count] = currentNode.Value;
                count++;
                currentNode = currentNode.Next;
            }

            return array;
        }

        public int[] GetArrayReverse()
        {
            int[] array = new int[_count];
            int count = 0;

            var currentNode = _tail;
            while (currentNode != null)
            {
                array[count] = currentNode.Value;
                count++;
                currentNode = currentNode.Previous;
            }

            return array;
        }
    }

    public class DoublyLinkedNode
    {
        public int Value { get; set; }
        public DoublyLinkedNode Next { get; set; }
        public DoublyLinkedNode Previous { get; set; }
    }
}
