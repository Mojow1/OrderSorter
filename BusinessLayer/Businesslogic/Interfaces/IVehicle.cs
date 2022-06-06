namespace orderSorter.Businesslogic.Interfaces
{
    public interface IVehicle
    {
        public int Id { get; set; }
        public double MaxCapacity { get;}
        public double ReservedCapacity { get; }
        public bool Availability { get;}
        
        public bool PermanentOutOfOrder { get; set; }
        

    }
}