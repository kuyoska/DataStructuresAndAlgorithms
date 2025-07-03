namespace ZTMCodeInterview.Queue
{
    public class QueueUsingStacks
    {
        private Stack<int> _data = new Stack<int>();
        
        public int Count { get { return _data.Count; } }        

        public void Push(int value)
        {            
            _data.Push(value);
        }

        public int Peek()
        {
            Stack<int> _temp = new Stack<int>();

            foreach (int item in _data)
            {
                _temp.Push(item);
            }

            return _temp.Peek();
        }

        public int Pop()
        {
            Stack<int> _temp = new Stack<int>();

            while (_data.Count > 0)
            {
                _temp.Push(_data.Pop());
            }

            int value = _temp.Pop();

            while (_temp.Count > 0)
            {
                _data.Push(_temp.Pop());
            }

            return value;
        }

        public bool Empty()
        {
            return _data.Count == 0;
        }
    }

    public class QueueUsingStacksBetter
    {
        private Stack<int> inputStack = new Stack<int>();
        private Stack<int> outputStack = new Stack<int>();

        public void Push(int x)
        {
            // Move elements from outputStack to inputStack
            while (outputStack.Count > 0)
            {
                inputStack.Push(outputStack.Pop());
            }

            // Push the new element onto inputStack
            inputStack.Push(x);

            // Move elements from inputStack to outputStack
            while (inputStack.Count > 0)
            {
                outputStack.Push(inputStack.Pop());
            }
        }
        public int Pop()
        {
            return outputStack.Pop();
        }

        public int Peek()
        {
            return outputStack.Peek();
        }

        public bool Empty()
        {
            return outputStack.Count == 0;
        }
    }
}
