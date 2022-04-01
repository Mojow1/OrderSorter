using System.Collections.Generic;

namespace orderSorter
{
    public class Order
    {
        private int _id;
        private Customer _customer;
        //private Date orderDate
        //private List<Product, int> _productsQuantity;
        private double _totalPrice;

        public Order(int id, Customer customer, double totalPrice)
        {
            _id = id;
            _customer = customer;
            _totalPrice = totalPrice;
        }
    }
}