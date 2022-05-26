using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Business;

namespace orderSorter
{
    public class Order : IOrder
    {
        private int _id;
        private DateTime _orderDate;
        private DateTime _allowedEndTime;
        private bool _priority;
        private bool _orderAccepted; 
        private int _orderWeight;
        private List<IProduct> _products;

       //private Dictionary<Product, int> products;
      
        // private double _totalPrice;

        public Order(int id, DateTime orderDate, DateTime allowedEndTime, bool priority, List<IProduct> products)
        {
            _id = id;
            _orderDate = orderDate;
            _allowedEndTime = allowedEndTime;
            _priority = priority;
            _products = products;
            _orderAccepted = false;
            _orderWeight = CalculateOrderWeight(products);
        }


        public int Id => _id;

        public DateTime OrderDate => _orderDate;

        public DateTime AllowedEndTime => _allowedEndTime;

        public bool Priority => _priority;

        public int OrderWeight => _orderWeight;

        public List<IProduct> Products => _products;

        public bool OrderAccepted
        {
            get => _orderAccepted;
            set => _orderAccepted = value;
        }

        
          public int CalculateOrderWeight(List<IProduct> products) // Method to calculate the orderweight
          {
              int orderWeight = 0;

              for (int i = 0; i < products.Count; i++)
              {
                  orderWeight = orderWeight + products[i].Weight;

              }
              return orderWeight;
          }
        
        
        
    }
}