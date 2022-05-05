using System;
using System.Collections.Generic;

namespace orderSorter
{
    public class Order
    {
        private int _id;
        private Customer _customer;
        private DateTime _orderDate;
        private Priority _priority;
        private List<ProductQuantity > _productsQuantity;
        private double _totalPrice;
        
        public Order(int id, Customer customer, DateTime orderDate, Priority priority, List<ProductQuantity> productsQuantity)
        {
            _id = id;
            _customer = customer;
            _orderDate = orderDate;
            _priority = priority;
            _productsQuantity =productsQuantity;
            _totalPrice = CalculateTotalPrice(productsQuantity);
        }
        
        public int Id => _id;

        public Customer Customer => _customer;

        public DateTime OrderDate => _orderDate;

        public Priority Priority => _priority;

        public List<ProductQuantity> ProductsQuantity => _productsQuantity;

        public double TotalPrice => _totalPrice;


        // Method to determine totalprice of the order
        public double CalculateTotalPrice(List<ProductQuantity> productsAndQuantity)
        {
            double price=0;
            if (productsAndQuantity.Count > 1)
            {
                foreach (var v  in productsAndQuantity)
                {
                    price = price + v.Product.Price * v.Quantity;
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