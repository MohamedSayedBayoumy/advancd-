using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.GenericClass
{
    internal class Box<T>
    {
        public T Value { get; set; }
        public Box(T value)
        {
            Value = value;
        }

    }
}
