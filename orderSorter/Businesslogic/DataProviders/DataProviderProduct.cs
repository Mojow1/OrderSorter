using System.Collections.Generic;

namespace orderSorter.DataProviders
{
    public interface DataProviderProduct
    {
        List<Product> fetchAllProducts();
    }
}