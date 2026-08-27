using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace advancd__.GenericMethods
{
    internal static class Utilities
    {
        public static void Swap<T>(ref T first , ref T second) {
            T temp = first;

            first = second;

            second = temp;
        }

        public static void PrintArray<T>(T[] array)
        {
            Console.WriteLine($"Array Elements: {string.Join(",", array)}");
        }


        public static T GetGetterNumber<T> (T[] array) where T : IComparable<T>
        {
            if (array is not null && array.Length > 0)
            {
                T max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].CompareTo(max) > 0)  
                        max = array[i];
                }
                return max;

            }

            return default;
          
        }

    }
}
