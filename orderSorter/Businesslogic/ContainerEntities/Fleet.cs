using System.Collections.Generic;
using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Fleet
{
    public class Fleet
    {
        private List<IVehicle> _vehicles;


        public Fleet(List<IVehicle> vehicles)
        {
            _vehicles = vehicles;
        }

        public void AddVehicle(IVehicle vehicle)
        {
            
        }

        public IVehicle FetchVehicle(int id)
        {
            
        }

        public List<IVehicle> FetchAllVehicles()
        {
            return _vehicles;
        }

        public void RemoveVehicle()
        {
            
        }
    }
}