using advancd__.GenericClass;
using advancd__.GenericConstraint.Constractor;
using advancd__.GenericConstraint.primary.general;
using advancd__.GenericConstraint.primary.special;
using advancd__.GenericInterfaces;
using advancd__.GenericMethods;
using advancd__.GenericsMultipleType;
using advancd__.StatisWithGeneric;

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

            #region Generic interfaces
            //ProductRepository product = new();
            //Proudct product01 = new Proudct(100, "Laptop", 1);
            //Proudct product02 = new Proudct(200, "Tv", 2);
            //product.Add(product01);
            //product.Add(product02);

            //List<Proudct> products = product.GetAllOfProudct();

            //Console.WriteLine(string.Join("\n", products));

            //Console.WriteLine("=============================================");


            //var productByid = product.GetById(2);

            //Console.WriteLine(productByid!.ToString());

            //Console.WriteLine("=============================================");

            //product.Remove(product01);

            //Console.WriteLine(string.Join(", ", products));
            #endregion

            #region Generic Constraint
            //// Clac<string> calc = new("5", "10");
            //// Clac<int> calc02 = new(5, 10); '// Here will be an error because int is Struct not class, and the generic constraint specifies that T must be a class (reference type).

            ////Cat myCat = new Cat { CountOfLegs = 4, CountOfEyes = 2 };
            ////Dog myDog = new Dog {};

            ////AnimalShelter<Ainmal> shelter = new AnimalShelter<Ainmal>();

            ////shelter.AddAnimal(myCat);
            //////shelter.AddAnimal(myDog); // Here will be an error because Dog class does not inherit from Ainmal class, and the generic constraint specifies that T must be a inherit of Ainmal.
            ////shelter.DisplayAnimals();

            //Factor factor = new Factor();
            //factor.Create<int>();
            ////factor.Create<Cat>(); // Here will be an error because Cat class does not have a parameterless constructor Cause this Class We Can able it if we go and add Parameterless constructor to Cat class

            #endregion

            #region Static With Generic
            //StaticClass.IncrementCount();
            //StaticClass.IncrementCount();
            //StaticClass.IncrementCount();

            //Console.WriteLine($"Count: {StaticClass.Count}");

            //StaticClass.IncrementCount();
            //StaticClass.IncrementCount();
            //StaticClass.IncrementCount();

            //Console.WriteLine($"After Edit: {StaticClass.Count}");

            StaticWithGeneric<int>.IncrementCount();
            StaticWithGeneric<int>.IncrementCount();
            StaticWithGeneric<int>.IncrementCount();
            
            Console.WriteLine($"Count Of Int: {StaticWithGeneric<int>.Count}");

            StaticWithGeneric<String>.IncrementCount();
            StaticWithGeneric<String>.IncrementCount();
            StaticWithGeneric<String>.IncrementCount();
            StaticWithGeneric<String>.IncrementCount();

            Console.WriteLine($"Count Of String: {StaticWithGeneric<String>.Count}");

            GenericClass<int> genericClass01 = new();
            genericClass01.IncrementCount();
            genericClass01.IncrementCount();
            genericClass01.IncrementCount();

            Console.WriteLine($"Count Of Int With Out Static Keyword: {genericClass01.Count}");

            GenericClass<String> genericClass02 = new();
            genericClass02.IncrementCount();

            Console.WriteLine($"Count Of String With Out Static Keyword: {genericClass02.Count}");

            #endregion

        }
    }
}
