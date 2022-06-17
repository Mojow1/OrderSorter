using System;
using System.Collections.Generic;
using System.Linq;
using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Interfaces;

//https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/how-to-explicitly-implement-interface-members
//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/interface-properties
namespace orderSorter.Businesslogic.Fleet
{
    public class Fleet
    {
        private List<IVehicle> _vehicles;


        public Fleet(List<IVehicle> vehicles) // Constructor
        {
            _vehicles = vehicles;
        }

        
        public void AddVehicle(IVehicle vehicle) // Setter is momenteel de enige optie.
        {
            int id = _vehicles.Count + 1;
            vehicle.Id = id;
            _vehicles.Add(vehicle);
            
        }
        

        public IVehicle FetchVehicle(int id)
        {
            return _vehicles.Find(x => x.Id == id);
            
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