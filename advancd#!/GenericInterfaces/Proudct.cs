using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.GenericInterfaces
{
    internal class Proudct
    {
        public Proudct(int price, string name, int id)
        {
            Price = price;
            Name = name;
            Id = id;
        }

        public int Price { get; set; }

        public string Name { get; set; }

        public int Id { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Price: {Price}";
        }
    }
}
