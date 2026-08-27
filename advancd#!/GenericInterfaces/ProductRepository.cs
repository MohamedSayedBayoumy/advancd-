using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.GenericInterfaces
{
    internal class ProductRepository : IRepository<Proudct>
    {
        private readonly List<Proudct> _products = new List<Proudct>();
        public void Add(Proudct entity)
        {
           _products.Add(entity);
        }

        public List<Proudct> GetAllOfProudct()
        {
            return _products;
        }

        public Proudct? GetById(int id)
        {
          
            return _products.Find(p => p.Id == id);
        }

        public void Remove(Proudct entity)
        {

            Proudct? product = GetById(entity.Id);
            if (product == null) return;

           _products.Remove(product);
        }
    }
}
