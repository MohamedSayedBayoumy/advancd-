using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.StatisWithGeneric
{
    internal class StaticWithGeneric<T>
    {

        static public int Count { get; private set; }

        static public void IncrementCount()
        {
            Count++;
        }

    }

    internal class GenericClass<T>
    {
          public int Count { get; private set; }

          public void IncrementCount()
        {
            Count++;
        }

    }
}
