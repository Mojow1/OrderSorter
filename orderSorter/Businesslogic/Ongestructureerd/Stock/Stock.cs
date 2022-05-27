using System.Collections.Generic;

namespace orderSorter
{
    public class Stock
    {
        private Dictionary<Product, int> products;

        public Stock(Dictionary<Product, int> products) // Constructor
        {
            this.products = products;
        }


        public Dictionary<Product, int> Products => products; // Gets productQuantity in stock
    }
}