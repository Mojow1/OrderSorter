using orderSorter.Businesslogic.Business;

namespace orderSorter
{
    public class Product : IProduct
    {
        private int _id;
        private string _name;
        private int _weight;


        public Product(int id, string name, int weight)
        {
            _id = id;
            _name = name;
            _weight = weight;
        }



        public int Id => _id;
        public string Name => _name;
        public int Weight => _weight;
    }
}