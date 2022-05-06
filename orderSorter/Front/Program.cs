using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Update.Internal;
using MySql.Data.MySqlClient;
using orderSorter.DatabaseMySQL;

namespace orderSorter
{
    class Program
    {
        // Eventueel pakbon en/of rit toevoegen aan Delivery map
        static void Main(string[] args)
        {
            
            Priority priority = new Priority(false);
            Customer customer = new Customer(1, "voornaam", "achternaam", "Straatnaam", 52, "6164VT", "Geleen");
            DateTime orderTime = DateTime.Now;

            Product p1 = new Product(1, "product1", 10);
            Product p2 = new Product(2, "product2", 20);
            Product p3 = new Product(3, "product3", 30);
            
            ProductQuantity product1 = new ProductQuantity(p1, 4);
            ProductQuantity product2 = new ProductQuantity(p2, 0);
            ProductQuantity product3 = new ProductQuantity(p3, 7);

            List<ProductQuantity> demanded = new List<ProductQuantity>();
            demanded.Add(product1);
            demanded.Add(product2);
            demanded.Add(product3);

            Order order = new Order(1, customer, orderTime, priority, demanded);
            int _normalPreparationTimeInMinutes = 30;
            int _busyKitchenTimeLossPercentage =25;
            int _priorityTimeSavingPercentage = 40;

            Kitchen busyKitchen= new BusyKitchen(order, _normalPreparationTimeInMinutes, _busyKitchenTimeLossPercentage, _priorityTimeSavingPercentage);
            IPreparedOrder kitchenHighPriorityHigh = busyKitchen.PrepareHighPriorityOrder();
            IPreparedOrder kitchenHighPriorityPrepared = busyKitchen.PrepareNormalPriorityOrder();

            Kitchen normalKitchen = new NormalKitchen(order, _normalPreparationTimeInMinutes, _priorityTimeSavingPercentage);
            IPreparedOrder kitchenNormalPriorityHigh = normalKitchen.PrepareHighPriorityOrder();
            IPreparedOrder kitchenPreparedPriorityPrepared = normalKitchen.PrepareNormalPriorityOrder();

           

            IPreparedOrder prepared = CalculatePreparingTimeKitchen(order, false, busyKitchen, normalKitchen);
            

        }
        
        // int normalPreparationTimeInMinutes, int busyKitchenTimeLossPercentage, int priorityTimeSavingPercentage

        // Calculates the preparing time of the kitchen minutes. It needs a BusyKitchen and a NormalKitchen. 
        static IPreparedOrder CalculatePreparingTimeKitchen(Order order, bool highWorkload, Kitchen busyKitchen, Kitchen normalKitchen)
        {
            IPreparedOrder prepared = null; 
            
            if (highWorkload == true)
            {
                if (order.Priority.PriorityStatus == true)
                { 
                    IPreparedOrder priorityOrder= busyKitchen.PrepareHighPriorityOrder();
                    prepared = priorityOrder;
                }
                
                else if (order.Priority.PriorityStatus == false)
                {
                    IPreparedOrder normalOrder = busyKitchen.PrepareNormalPriorityOrder();
                    prepared = normalOrder;

                }
            }
            
            else if (highWorkload == false)
            {
                if (order.Priority.PriorityStatus == true)
                {
                 IPreparedOrder priorityOrder= normalKitchen.PrepareHighPriorityOrder();
                 prepared = priorityOrder;
                }
                
                else if (order.Priority.PriorityStatus == false)
                {
                    IPreparedOrder normalOrder = normalKitchen.PrepareNormalPriorityOrder();
                    prepared = normalOrder;
                }
            }

            return prepared;
        }

    }
    

    
}