namespace advancd__.GenericConstraint.primary.special
{
    internal class Clac<T> where T: class?
    {
        public Clac(T firstNumber, T secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public T FirstNumber { get; set; }
        public T SecondNumber { get; set; }

    }
}
