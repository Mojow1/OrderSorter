using System.Collections.Generic;
using orderSorter.DataProviders;

namespace orderSorter.Mocking;

public class MockingProducts:IDataProviderProduct
{
    public void AddProduct(Product product)
    {
        throw new System.NotImplementedException();
    }

    public Product FetchProduct(int id)
    {
        throw new System.NotImplementedException();
    }

    public List<Product> FetchAllProducts()
    {
        throw new System.NotImplementedException();
    }
}