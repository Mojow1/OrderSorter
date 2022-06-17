using System.Collections.Generic;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.DataProviders
{
    public interface DataProviderVehicle
    {
        List<IVehicle> fetchAllVehicles();
    }
}