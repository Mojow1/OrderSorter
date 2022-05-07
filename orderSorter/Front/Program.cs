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
            
            Priority priority = new Priority(false);
            Order order = new Order(1, customer, orderTime, true, demanded);

            Console.WriteLine( order.OrderSize);






        }



        
        // int normalPreparationTimeInMinutes, int busyKitchenTimeLossPercentage, int priorityTimeSavingPercentage

        // Calculates the preparing time of the kitchen minutes. It needs a BusyKitchen and a NormalKitchen. 
       

    }
    

    
}