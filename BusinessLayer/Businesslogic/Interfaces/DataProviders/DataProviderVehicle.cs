using System.Collections.Generic;
using orderSorter.Businesslogic.Fleet;

namespace orderSorter.DataProviders
{
    public interface DataProviderVehicle
    {
        List<Car> fetchAllVehicles();
    }
}