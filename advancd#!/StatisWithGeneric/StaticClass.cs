using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.StatisWithGeneric
{
    internal class StaticClass
    {
       static public int Count { get; private set; }
        
        static public void IncrementCount()
        {
            Count++;
        }

    }
}
