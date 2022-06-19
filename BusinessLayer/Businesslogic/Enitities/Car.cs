using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Fleet
{
    public class Car : IVehicle
    {
        public int Id { get; set; }
        public double MaxCapacity { get;}
        public double ReservedCapacity { get; }
        public bool Availability { get;}
        public bool InUse { get; set; }

        public Car(int id, double maxCapacity, double reservedCapacity, bool availability, bool outOfOrder)
        {
            Id = id;
            MaxCapacity = maxCapacity;
            ReservedCapacity = reservedCapacity;
            Availability = availability;
            InUse = outOfOrder;
        }
    }
}