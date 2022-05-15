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
        private List<ProductQuantity > _productsQuantity;
        private double _totalPrice;
        private int _orderSize;
        private DateTime _timeDifference;
        private PackingSlipKitchen _packingSlipKitchen;
        
        
        public Order(int id, Customer customer, DateTime orderDate, bool priority, List<ProductQuantity> productsQuantity)
        {
            _id = id;
            Customer = customer;
            _orderDate = orderDate;
            _priority = priority;
            _productsQuantity =productsQuantity;
            _totalPrice = CalculateTotalPrice(productsQuantity);
            _timeDifference = orderDate.AddHours(2);
        }
        
        public int Id => _id;

        public Customer Customer { get; }

        public DateTime OrderDate => _orderDate;

        public bool Priority => _priority;

        public List<ProductQuantity> ProductsQuantity => _productsQuantity;

        public double TotalPrice => _totalPrice;

        public int OrderSize => _orderSize;

        public PackingSlipKitchen PackingSlipKitchen
        {
            get => _packingSlipKitchen;
            set => _packingSlipKitchen = value;
        }

        public DateTime TimeDifference => _timeDifference;


        // Method to determine totalprice of the order
        public double CalculateTotalPrice(List<ProductQuantity> productsAndQuantity)
        {
            double price=0;
            int size = 0;
            
            if (productsAndQuantity.Count > 1)
            {
                foreach (var v  in productsAndQuantity)
                {
                    price = price + v.Product.Price * v.Quantity;
                    _orderSize = _orderSize + v.Quantity;
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