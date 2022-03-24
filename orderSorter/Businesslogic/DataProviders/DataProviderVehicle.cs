using System.Collections.Generic;

namespace orderSorter.DataProviders
{
    public interface DataProviderVehicle
    {
        List<Vehicle> fetchAllVehicles();
    }
}