using System.Collections.Generic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter
{
    public class Stock
    {
        private List<IProduct> _products;

        public Stock(List<IProduct> products) // Constructor
        {
            _products = products;
        }

        public void AddProduct(IProduct product)
        {
            int id = _products.Count + 1;
            product.Id = id;
            _products.Add(product);
        }

        public IProduct FetchProduct(int id)
        {
            int index = _products.FindIndex(x => x.Id == id);
            return _products[index];
        }

        public List<IProduct> FetchAllProducts()
        {
            return _products;
        }

        public void RemoveProduct(int id)
        {
            int index = _products.FindIndex(x => x.Id == id);
            _products[index].OutOfOrder = true;
        }


    }
}