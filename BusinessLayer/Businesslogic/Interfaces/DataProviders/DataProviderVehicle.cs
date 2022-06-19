using System.Collections.Generic;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.DataProviders
{
    public interface DataProviderVehicle
    {
        public void AddVehicle(IVehicle vehicle);

        public IVehicle FetchVehicle();
        List<IVehicle> fetchAllVehicles();
    }
}