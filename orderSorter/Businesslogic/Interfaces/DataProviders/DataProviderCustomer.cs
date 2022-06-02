using System.Collections;
using System.Collections.Generic;

namespace orderSorter.DataProviders
{
    public interface DataProviderCustomer
    {

        List<Customer> fetchAllUsers();
    }
}