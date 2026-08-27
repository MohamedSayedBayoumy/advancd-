using advancd__.GenericClass;
using advancd__.GenericMethods;
using advancd__.GenericsMultipleType;

namespace advancd__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Normal Generic
            //Box<int> BoxOfElements = new Box<int>(value: 5);

            //Console.WriteLine($"Value in Box: {BoxOfElements.Value}"); 
            #endregion

            #region Generics Multiple Type 
            //Calc<int, double> Total = new(10 , 10.5);
            //double result = Total.Calculate();

            //Console.WriteLine($"Total: {result}");

            #endregion

            #region Generic Methods
            //int a = 10, b = 20;
            //Utilities.Swap(ref a , ref b);

            //Console.WriteLine($"a: {a} , b: {b}");

            //Utilities.PrintArray<int>(new int[] { 1, 2, 3, 4, 5 });
            //Utilities.PrintArray(new Object[] { 1, "2", false, 4, "Mohamed"});

            //int[] array = { 500 , 1, 2, 3, 4, 5 , 300 };
            //var value = Utilities.GetGetterNumber(array);
            //Console.WriteLine($"value: {value}");

            #endregion

        }
    }
}
