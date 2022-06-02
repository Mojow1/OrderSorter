using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.DataProviders
{
    public interface IDataProviderIProduct
    {

        public void AddIProduct(IProduct product);
        public IProduct FetchIProduct();
        public List<IProduct> FetchAllProducts();
    }
}