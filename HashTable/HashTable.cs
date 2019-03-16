using System;
using System.Collections;

namespace Hash_Table
{
    public class HashTable<Tkey, Telement>
    {
        public HashTable(int capacity)
        {
            if (capacity <= 0) throw new InvalidOperationException("Capacity must be positive");
            size_ = capacity;
            data_ = new Data[size_];
        }

        public void Add(Tkey key, Telement element)
        {
            int hKey = Hash(key);
            Data newNode = new Data(key, element);

            if (data_[hKey] == null)
            {
                data_[hKey] = newNode;
            }
            else
            {
                Data lastNode = data_[hKey];
                while(lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
            }
        }

        public void Remove(Tkey key)
        {
            Data node = data_[Hash(key)];

            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    node = null;
                    return;
                }
                else
                {
                    node = node.Next;
                }
            }

            throw new InvalidOperationException("Element Not Found");
        }

        public Telement Get(Tkey key)
        {
            Data lastNode = data_[Hash(key)];

            while (lastNode != null)
            {
                if (lastNode.Key.Equals(key))
                {
                    return lastNode.Element;
                }
            }

            throw new IndexOutOfRangeException("Not Found");
        }

        public Telement this[Tkey key]
        {
            get { return Get(key); }
            set { Add(key, value); }
        }

        private int Hash(Tkey key)
        {
            return Math.Abs(key.GetHashCode() % (size_));
        }

        private int size_;
        private Data[] data_;

        public class Data
        {
            public Data(Tkey key, Telement element)
            {
                Key = key;
                Element = element;
                Next = null;
            }

            public Tkey Key { get; }
            public Telement Element { get; set; }
            public Data Next { get; set; }
        }
    }
}
