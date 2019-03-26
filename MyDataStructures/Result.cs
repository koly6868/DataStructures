using System;
using System.Collections.Generic;
using System.Text;

namespace MyDataStructures
{
    class Result<T>
    {
        public Result(T value, bool isOK)
        {
            Value = value;
            IsOK = isOK;
        }

        public T Value { get; }
        public bool IsOK { get; }
    }
}
