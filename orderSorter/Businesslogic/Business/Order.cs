using System;
using System.Collections.Generic;

namespace orderSorter
{
    public class Order
    {
        private int _id;
        private Customer _customer;
        private DateTime _orderDate;
        private DeliveryPriority _deliveryPriority;
        private List<OrderDetails> _productsAndQuantity;
        private double _totalPrice;
        
        public Order(int id, Customer customer, DateTime orderDate, DeliveryPriority deliveryPriority, List<OrderDetails> productsAndQuantity)
        {
            _id = id;
            _customer = customer;
            _orderDate = orderDate;
            _deliveryPriority = deliveryPriority;
            _productsAndQuantity = productsAndQuantity;
            _totalPrice = CalculateTotalPrice(productsAndQuantity);
        }
        
        
        // Method to determine totalprice of the order
        public double CalculateTotalPrice(List<OrderDetails> productsAndQuantity)
        {
            double price=0;
            if (productsAndQuantity.Count > 1)
            {
                foreach (var v  in productsAndQuantity)
                {
                    price = price + v.Product1.Price * v.Quantity1;
                }
                
            }
            else
            {
                price = 0;
            }
            
            return price;
        }
        
        
    }
}