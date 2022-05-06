using System.Collections.Generic;

namespace orderSorter
{
    public class Fleet
    {
        private List<Vehicle> _deliveryVehicles;

        public Fleet(List<Vehicle> deliveryVehicles)
        {
            _deliveryVehicles = deliveryVehicles;
        }

        public List<Vehicle> DeliveryVehicles => _deliveryVehicles;


        public void addVehicle(Vehicle vehicle)
        {
            _deliveryVehicles.Add(vehicle);
        }
        
        
        
    }
}