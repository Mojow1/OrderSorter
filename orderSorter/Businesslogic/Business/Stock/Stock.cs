using System.Collections.Generic;

namespace orderSorter
{
    public class Stock
    {
        private List<ProductQuantity> _productQuantity;
        
        
        

        public Stock(List<ProductQuantity> productQuantity)
        {
            _productQuantity = productQuantity;
        }
        
        
        

        public List<ProductQuantity> ProductsQuantity
        {
            get => _productQuantity;
            set => _productQuantity = value;
        }
    }
}