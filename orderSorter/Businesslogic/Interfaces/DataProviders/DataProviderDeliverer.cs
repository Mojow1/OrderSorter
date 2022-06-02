using System.Collections.Generic;
using orderSorter.Businesslogic.Business.Staff;

namespace orderSorter.DataProviders
{
    public interface DataProviderDeliverer
    {
        List<IEmployee> fetchAllDeliverers();
    }
}