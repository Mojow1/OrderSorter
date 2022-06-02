using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Fleet
{
    public class Car : IVehicle
    {
        private int _id;
        private double _maxCapacity;
        private double _reservedCapacity;
        private bool _availability;

        public Car(int id, double maxCapacity, double reservedCapacity, bool availability)
        {
            _id = id;
            _maxCapacity = maxCapacity;
            _reservedCapacity = reservedCapacity;
            _availability = availability;
        }


        public int Id => _id;
        public double MaxCapacity => _maxCapacity;
        public double ReservedCapacity
        {
            get { return _reservedCapacity; }
            set { _reservedCapacity = value; }
        }

        public bool Availability => _availability;
        
        
        
    }
}