using System.Collections.Generic;

namespace orderSorter
{
    public class Fleet
    {
        private List<IDeliver> _deliveryVehicles;

        public Fleet(List<IDeliver> deliveryVehicles)
        {
            _deliveryVehicles = deliveryVehicles;
        }

        public List<IDeliver> DeliveryVehicles => _deliveryVehicles;


        public void addVehicle(IDeliver vehicle)
        {
            _deliveryVehicles.Add(vehicle);
        }
        
        
        
    }
}