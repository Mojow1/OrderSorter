using Castle.Components.DictionaryAdapter;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter
{
    public class Product 
    {

        public int Id { get;  }
        public string Name { get;  } 
        public int Weight { get;  }
        public bool InStock { get;  }


        public Product(int id, string name, int weight, bool inStock)
        {
            Id = id;
            Name = name;
            Weight = weight;
            InStock = inStock;
        }
    }
}