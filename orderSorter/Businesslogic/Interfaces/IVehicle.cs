namespace orderSorter.Businesslogic.Interfaces
{
    public interface IVehicle
    {
        public int Id { get; }
        public double MaxCapacity { get;}
        public double ReservedCapacity { get; }
        public bool Availability { get;}
        

    }
}