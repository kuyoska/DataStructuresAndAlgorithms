using System.IO.Pipes;

namespace ZTMCodeInterview.HashTable
{
    public class HashTable
    {
        private class MyNodes : List<HashTableElement> { }
        private MyNodes[] _data;
        private int _count;

        public int Count { get { return _count; } }

        public HashTable(int size)
        {
            _data = new MyNodes[size];
        }

        private int Hash(string key)
        {
            int hash = 0;

            for(int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i) % _data.Length;
            }

            return hash;
        }

        public void Set(string key, int value)
        {
            int hashIndex = Hash(key);

            if (_data[hashIndex] == null)
            {
                _data[hashIndex] = new MyNodes();
            }

            _data[hashIndex].Add(new HashTableElement { Key = key, Value = value });

            _count++;
        }

        public int Get(string key)
        {
            int hashIndex = Hash(key);

            var hashElement = _data[hashIndex];

            if (hashElement == null) throw new Exception("Key does not exist");

            return hashElement.FirstOrDefault(k => k.Key == key).Value;
        }

        public IEnumerable<string> GetKeys()
        {
            foreach(var bucket in _data.Where(b => b != null))
            {
                foreach(var element in bucket)
                {
                    yield return element.Key;
                }
            }
        }
    }

    public class HashTableElement
    {
        public string Key { get; set; }
        public int Value { get; set; }
    }
}
