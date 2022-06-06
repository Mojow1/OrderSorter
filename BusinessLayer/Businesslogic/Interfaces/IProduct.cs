namespace orderSorter.Businesslogic.Interfaces
{
    public interface IProduct
    {
        public int Id { get; set; }
        public string Name { get;}
        public int Weight { get;}
        
        public bool OutOfOrder { get; set; }
    }
}