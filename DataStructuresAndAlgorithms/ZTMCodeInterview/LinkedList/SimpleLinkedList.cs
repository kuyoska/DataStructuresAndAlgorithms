using System.Collections.Generic;

namespace ZTMCodeInterview.LinkedList
{
    public class SimpleLinkedList
    {
        private SimpleLinkedNode _head;
        private SimpleLinkedNode _tail;
        private int _count = 0;

        public int Count { get { return _count; } }
        public int Head { get { return _head.Value; } }
        public int Tail { get { return _tail.Value; } }

        public void AddToStart(int value)
        {
            var newHead = new SimpleLinkedNode { Value = value };

            if (_head == null)
            {                
                _head = newHead;
                _tail = newHead;
            }
            else
            {
                newHead.Next = _head;
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
                var newTail = new SimpleLinkedNode { Value = value };
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

            var newNode = new SimpleLinkedNode { Value = value };

            for (int i = 1; i <= position; i++)
            {
                if(i == position)
                {
                    var previousNode = currentNode;
                    newNode.Next = previousNode.Next;
                    previousNode.Next = newNode;
                }
                else currentNode = currentNode.Next;
            }

            _count++;
        }

        public bool Search(int value)
        {
            var currentNode = _head;
            while(currentNode != null)
            {
                if (currentNode.Value == value)
                    return true;
                else currentNode = currentNode.Next;
            }

            return false;
        }

        public int Remove(int position)
        {
            if (_count == 0) throw new Exception("Linked list is empty");

            int value = _head.Value;

            if(position == 1)
            {
                var currentHead = _head;
                _head = currentHead.Next;
                currentHead = null;
                _count--;
            }
            else 
            {
                var currentNode = _head;

                for (int i = 1; i <= position; i++)
                {
                    if (i == position - 1)
                    {
                        var nodeToRemove = currentNode.Next;
                        currentNode.Next = nodeToRemove.Next;
                        value = nodeToRemove.Value;
                        nodeToRemove = null;
                        _count--;
                        return value;
                    }
                    else currentNode = currentNode.Next;
                }
            }

            return value;
        }

        public void Reverse()
        {
            if (_count <= 1) return;

            var first = _head;
            var second = first.Next;
            _tail = _head;

            while (second != null)
            {
                var third = second.Next;
                second.Next = first;
                first = second;
                second = third;
            }

            _head.Next = null;
            _head = first;
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
    }

    public class SimpleLinkedNode
    {
        public int Value {  get; set; }
        public SimpleLinkedNode Next { get; set; }
    }
}
