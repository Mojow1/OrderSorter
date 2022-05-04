using System;

namespace orderSorter
{
    public class StockChecker
    {
        private OrderDetails _orderDetails;
        private Stock _stock;

        public StockChecker(Order order, Stock stock)
        {
            _orderDetails = _orderDetails;
            _stock = stock;
        }

        public OrderDetails OrderDetails => _orderDetails;

        public Stock Stock => _stock;
        
        
        
        
        // Checks if products from order are in stock; if yes returns true
        public Boolean CheckStock()
        {
            if (_orderDetails.Product1 == _stock.Product && _orderDetails.Quantity1 >= _stock.Quantity)
            {

                return true;
            }

            else
            {
                return false;
            }
            
        }
    }
}