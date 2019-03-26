using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataStructures.Additional
{
    public struct Couple<T1, T2>
    {
        public Couple(T1 first, T2 second) : this()
        {
            Key = first;
            Value = second;
        }

        public T1 Key { get; set; }
        public T2 Value { get; set; }
    }
}
