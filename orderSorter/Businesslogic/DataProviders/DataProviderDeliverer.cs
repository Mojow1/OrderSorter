using System.Collections.Generic;

namespace orderSorter.DataProviders
{
    public interface DataProviderDeliverer
    {
        List<Deliverer> fetchAllDeliverers();
    }
}