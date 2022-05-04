namespace orderSorter
{
    public class Product
    {
        private int id;
        private string name;
        private double price;

        public Product(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public double Price => price;
    }
}