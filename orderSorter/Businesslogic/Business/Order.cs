using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace orderSorter
{
    public class Order
    {
        private int _id;
        private DateTime _orderDate;
        private bool _priority;
        private double _totalPrice;
        private int _orderSize;
        private DateTime _timeDifference;
        private Dictionary<Product, int> products;




        public Order(int id, Customer customer, DateTime orderDate, bool priority, Dictionary<Product, int> products)
        {
            _id = id;
            Customer = customer;
            _orderDate = orderDate;
            _priority = priority;
            this.products = products;
            _timeDifference = orderDate.AddHours(2);
            _totalPrice = CalculateTotalPrice(products);
        }

        public int Id => _id;

        public Customer Customer { get; }

        public DateTime OrderDate => _orderDate;

        public bool Priority => _priority;
        

        public double TotalPrice => _totalPrice;

        public int OrderSize => _orderSize;

    

        public DateTime TimeDifference => _timeDifference;


        // Method to determine totalprice of the order
          public double CalculateTotalPrice (Dictionary<Product, int> products)
        {
            double price=0;
            int size = 0;


            if (products.Count > 0)
            {
                foreach (var product in products)
                {
                    price = price + product.Key.Price * product.Value;
                    _orderSize = _orderSize + product.Value;
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