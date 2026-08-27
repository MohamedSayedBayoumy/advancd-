using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.GenericConstraint.Constractor
{
    internal class Factor
    {
        public T Create<T>() where T: new()  
        {
            return new T();
        }
    }
}
