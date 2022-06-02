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
            
        }

        public IProduct FetchProduct(int id)
        {
            
        }

        public List<IProduct> FetchAllProducts()
        {
            return _products;
        }

        public void RemoveProduct(int id)
        {
            
        }


    }
}