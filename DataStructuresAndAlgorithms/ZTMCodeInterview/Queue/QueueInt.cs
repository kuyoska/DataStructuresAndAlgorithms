using Microsoft.VisualBasic;
using ZTMCodeInterview.LinkedList;

namespace ZTMCodeInterview.Queue
{
    public class QueueInt
    {
        private SimpleLinkedList _data;

        public QueueInt()
        {
            _data = new SimpleLinkedList();
        }

        public int Count { get { return _data.Count; } }

        public void Enqueue(int value)
        {
            _data.AddToEnd(value);
        }

        public int Peek(PeekDirection direction)
        {
            switch(direction)
            {
                case PeekDirection.Front: return _data.Head;
                case PeekDirection.Back: return _data.Tail;
            }

            return 0;
        }

        public int Dequeue()
        {
            return _data.Remove(1);
        }

        public int[] GetArray()
        {
            return _data.GetArray();
        }
    }

    public enum PeekDirection
    {
        Front,
        Back,
    }
}
