using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.GenericsMultipleType
{
    internal class Calc<R1 ,R2>
    {
        public Calc(R1 firstNumber, R2 secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public R1 FirstNumber{ get; set; }

        public R2 SecondNumber { get; set; }

        public double Calculate()
        {
            return Convert.ToDouble((dynamic)FirstNumber! + (dynamic)SecondNumber!);
        }
    }
}
