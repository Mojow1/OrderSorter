using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

// https://circle.visual-paradigm.com/simple-order-system/
namespace orderSorter
{
    public class Order 
    {
        
        public int Id { get; set; }
        public DateTime OrderDate { get; }
        public DateTime AllowedEndTime { get;  }
        public bool Priority { get;  }
        public bool OrderAccepted { get; set; }
        public int OrderWeight { get; }
        public List<Product> Products { get;  }


        public Order(int id, DateTime orderDate, DateTime allowedEndTime, bool priority, bool orderAccepted,  List<Product> products)
        {
            Id = id;
            OrderDate = orderDate;
            AllowedEndTime = allowedEndTime;
            Priority = priority;
            OrderAccepted = orderAccepted;
            OrderWeight = CalculateOrderWeight(products);
            Products = products;
        }

    
        
        public Order(int id, DateTime orderDate, DateTime allowedEndTime, bool priority, bool orderAccepted) // ctr voor database tabel
        {
            Id = id;
            OrderDate = orderDate;
            AllowedEndTime = allowedEndTime;
            Priority = priority;
            OrderAccepted = orderAccepted;
        }
        
        


        private int CalculateOrderWeight(List<Product> products)
        {
            int orderWeight = 0;

            foreach (var ow in products)
            {
                orderWeight = orderWeight + ow.Weight;
            }

            return orderWeight;
        }
        
        
    }
}