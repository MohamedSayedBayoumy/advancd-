using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.GenericConstraint.primary.general
{
    internal abstract class Ainmal
    {
        public required int CountOfLegs { get; set; }

        public required int CountOfEyes { get; set; }

        public abstract void Speak();

        public override string ToString()
        {
            return $"Animal with {CountOfLegs} legs and {CountOfEyes} eyes";
        }
    }
}
