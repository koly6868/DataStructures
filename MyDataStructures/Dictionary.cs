using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures
{
    public class Dictionary<TKey, TElement>
    {
        public Dictionary(int capacity)
        {
            if (capacity <= 0) throw new InvalidOperationException("Capacity must be positive");
            size_ = capacity;
            data_ = new DateNode[size_];
        }



        public Dictionary(IEnumerable<TKey> keys, IEnumerable<TElement> elements, int? size = null)
        {
            if (size == null)
            {
                size_ = keys.Count();
                if (size_ != elements.Count()) throw new ArgumentException("Arguments have different size");
            }
            else
            {
                size_ = size.Value;
            }
            data_ = new DateNode[size_];
            IEnumerator<TKey> keysEnumerator = keys.GetEnumerator();
            IEnumerator<TElement> elementsEnumerator = elements.GetEnumerator();

            for (int i = 0; i < size_; i++)
            {
                elementsEnumerator.MoveNext();
                keysEnumerator.MoveNext();
                Add(keysEnumerator.Current, elementsEnumerator.Current);
            }
        }



        public void Add(TKey key, TElement element)
        {
            int hKey = Hash(key);
            DateNode newNode = new DateNode(key, element);

            if (data_[hKey] == null)
            {
                data_[hKey] = newNode;
            }
            else
            {
                DateNode lastNode = data_[hKey];
                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = newNode;
            }
        }



        public void Remove(TKey key)
        {
            DateNode lastNode = data_[Hash(key)];

            while (lastNode != null)
            {
                if (lastNode.Next.Key.Equals(key))
                {
                    lastNode.Next = lastNode.Next.Next;
                    return;
                }
                else
                {
                    lastNode = lastNode.Next;
                }
            }

            throw new InvalidOperationException("Element Not Found");
        }



        public TElement Get(TKey key)
        {
            DateNode lastNode = data_[Hash(key)];

            while (lastNode != null)
            {
                if (lastNode.Key.Equals(key))
                {
                    return lastNode.Element;
                }
                lastNode = lastNode.Next;
            }

            throw new IndexOutOfRangeException("Not Found");
        }



        public TElement this[TKey key]
        {
            get { return Get(key); }
            set { Add(key, value); }
        }



        private int Hash(TKey key)
        {
            return Math.Abs(key.GetHashCode() % (size_));
        }



        private int size_;
        private DateNode[] data_;



        class DateNode
        {
            public DateNode(TKey key, TElement element)
            {
                Key = key;
                Element = element;
                Next = null;
            }

            public TKey Key { get; }
            public TElement Element { get; set; }
            public DateNode Next { get; set; }
        }
    }
}
