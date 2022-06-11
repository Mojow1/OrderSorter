using Castle.Components.DictionaryAdapter;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter
{
    public class Product : IProduct
    {
     
        private int _id;
        private string _name;
        private int _weight;
        private bool _inStock;


        public Product(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }


        public Product(int id, string name, int weight, bool inStock)
        {
            _id = id;
            _name = name;
            _weight = weight;
            _inStock = inStock;
        }
        
 

        
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name => _name;
        public int Weight => _weight;

        public bool InStock
        {
            get => _inStock; 
            set=> _inStock= value;
        }
        
        
 
    }
}