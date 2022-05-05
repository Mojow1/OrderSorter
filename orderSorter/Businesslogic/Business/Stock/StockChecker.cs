using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace orderSorter
{
    public class StockChecker
    {
        private Order _order;
        private Stock _stock;
        
        public StockChecker(Order order, Stock stock)
        {
            _order = order;
            _stock = stock;
        }

        // Checks if products from order are in stock; if yes returns true, if not return false
        public bool CheckStock()
        {
            List <bool> status = new List<bool>();
            
            for (int i = 0; i < _order.ProductsQuantity.Count; i++)
            {
                int id = _order.ProductsQuantity[i].Product.Id;
                
                
                
                for (int j = 0; j < _stock.ProductsQuantity.Count; j++)
                {
                    if (id == _stock.ProductsQuantity[j].Product.Id &&
                        _order.ProductsQuantity[i].Quantity <= _stock.ProductsQuantity[j].Quantity )
                    {
                        status.Add(true);
                    }
                    
                    else if (_order.ProductsQuantity[i].Product.Id == _stock.ProductsQuantity[j].Product.Id &&
                             _order.ProductsQuantity[i].Quantity >= _stock.ProductsQuantity[j].Quantity)
                    {
                        status.Add(false);
                    }
                    
                    if (status.Contains(false))
                    {
                        return false;
                    }
                    
                }
                
            }
            
            return true;

        }
    }
}