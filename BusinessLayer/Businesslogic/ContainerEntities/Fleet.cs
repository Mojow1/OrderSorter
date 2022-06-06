using System;
using System.Collections.Generic;
using System.Linq;
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
            int id = _vehicles.Count + 1;
            vehicle.Id = id;
            _vehicles.Add(vehicle);
        }
        

        public IVehicle FetchVehicle(int id)
        {
            int index = _vehicles.FindIndex(x => x.Id == id);
            return _vehicles[index];
        }

        public List<IVehicle> FetchAllVehicles()
        {
            return _vehicles;
        }

        public void RemoveVehicle(int id)
        {
            int index = _vehicles.FindIndex(x => x.Id == id);
            _vehicles[index].PermanentOutOfOrder = true;
        }
    }
}