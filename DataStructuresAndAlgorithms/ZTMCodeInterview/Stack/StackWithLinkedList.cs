using ZTMCodeInterview.LinkedList;

namespace ZTMCodeInterview.Stack
{
    public class StackWithLinkedList
    {
        private SimpleLinkedList _data;

        public StackWithLinkedList()
        {
            _data = new SimpleLinkedList();
        }

        public int Count { get { return _data.Count; } }

        public void Push(int value)
        {
            _data.AddToStart(value);
        }

        public int Peek()
        {
            return _data.Head;
        }

        public int Pop()
        {
            return _data.Remove(1);
        }

        public int[] GetArray()
        {
            return _data.GetArray();
        }
    }
}
