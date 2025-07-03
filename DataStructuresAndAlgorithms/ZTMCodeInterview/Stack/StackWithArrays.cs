namespace ZTMCodeInterview.Stack
{
    public class StackWithArrays
    {
        private int[] _data;
        private int _count;

        public StackWithArrays(int size)
        {
            _data = new int[size];
        }

        public int Count { get { return _count; } }

        public void Push(int value)
        {
            if(_count == _data.Length)//we should allocate more memory
            {
                CreateNewArray();
            }

            _data[_count] = value;
            _count++;
        }

        private void CreateNewArray()
        {
            var temp = new int[_data.Length * 2];

            for (int i = 0; i < _data.Length; i++)
            {
                temp[i] = _data[i];
            }

            _data = temp;
        }

        public int Peek()
        {
            return _data[_count - 1];
        }

        public int Pop()
        {
            if (_count == 0) throw new Exception("No data to pop");

            var data = _data[_count - 1];
            _count--;
            return data;
        }

        public int[] GetArray()
        {
            var array = new int[_count];

            for(int i = _count - 1; i >= 0; i--)
            {
                array[(array.Length - 1 ) - i] = _data[i];
            }

            return array;
        }
    }
}
