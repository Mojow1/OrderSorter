using System.Collections.Generic;
using System.Linq;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter
{
    public class Stock
    {
        private List<Product> _products;

        public Stock(List<Product> products) // Constructor
        {
            _products = products;
        }

        public void AddProduct(Product product)
        {
            int id = _products.Count + 1;
            Product newProduct = new Product(id, product.Name, product.Weight, product.InStock);
            _products.Add(newProduct);
        }

        public Product FetchProduct(int id) // Fetch product by ID property
        {
        return _products.Find(x => x.Id == id);
       
        }

        public List<Product> FetchAllProducts()
        {
            return _products;
        }

        public void RemoveProduct(int id) // Het product wordt niet volledig verwijderd krijgt een bool out of stock. Dit in verband met id nummering.
        {
            Product productToRemove = _products.Find(x => x.Id == id);
            if (productToRemove != null) // indien die dus bestaat.
            {
                Product productOutOfStock =
                    new Product(productToRemove.Id, productToRemove.Name, productToRemove.Weight, false);
            
                int index = _products.FindIndex(x => x == productToRemove);
                _products[index] = productOutOfStock;
            }
        }


    }
}