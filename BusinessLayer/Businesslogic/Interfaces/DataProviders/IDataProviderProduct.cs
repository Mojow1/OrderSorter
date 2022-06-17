using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.DataProviders
{
    public interface IDataProviderProduct
    {

        public void AddProduct(Product product);
        public Product FetchProduct(int id);
        public List<Product> FetchAllProducts();
    }
}