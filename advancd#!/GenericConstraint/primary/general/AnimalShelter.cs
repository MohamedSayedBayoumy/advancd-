using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace advancd__.GenericConstraint.primary.general
{
    internal class AnimalShelter<T> where T : Ainmal
    {
        private readonly List<T> _animals = [];

        public void AddAnimal(T animal)
        {
            _animals.Add(animal);
        }

        public void DisplayAnimals()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine($"{animal.ToString()}");
                animal.Speak();
            }
        }
    }
}
