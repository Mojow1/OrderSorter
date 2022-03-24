using System.Collections.Generic;

namespace orderSorter.DataProviders
{
    public interface DataProviderOrder
    {
        List<Order> fetchAllOrders();
    }
}