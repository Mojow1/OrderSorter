namespace orderSorter
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        
        
        public Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public int Id => _id;

        public string Name => _name;

        public double Price => _price;
    }
}