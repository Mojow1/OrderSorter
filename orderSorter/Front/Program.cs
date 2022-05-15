using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Castle.Core.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using orderSorter.Businesslogic.Algoritme;
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

            List<ProductQuantity> demanded =new List<ProductQuantity>();
            demanded.Add(product1);
            demanded.Add(product2);
            demanded.Add(product3);

            Priority priority = new Priority(false);


            DateTime time1 = new DateTime(2022, 5, 8, 16, 0, 0);
            DateTime time2 = new DateTime(2022, 5, 8, 17, 0, 0);
            DateTime time3 = new DateTime(2022, 5, 8, 18, 0, 0);
            DateTime time4 = new DateTime(2022, 5, 8, 19, 0, 0);
            DateTime time5 = new DateTime(2022, 5, 8, 20, 0, 0);
            DateTime time6 = new DateTime(2022, 5, 8, 21, 0, 0);
            DateTime time7 = new DateTime(2022, 5, 8, 22, 0, 0);
            DateTime time8 = new DateTime(2022, 5, 8, 23, 0, 0);
            DateTime time9 = new DateTime(2022, 5, 9, 0, 0, 0);
            
            
            
            
            Timeslot timeslot2 = new Timeslot(3, 1, time2, time3);
            Timeslot timeslot3 = new Timeslot(3, 2, time3, time4);

            Timeslot timeslot4 = new Timeslot(3, 3, time4, time5);
            Timeslot timeslot5 = new Timeslot(3, 4, time5, time6);
            Timeslot timeslot6 = new Timeslot(3, 5, time6, time7);
            Timeslot timeslot7 = new Timeslot(3, 6, time7, time8);
            Timeslot timeslot8 = new Timeslot(3, 7, time8, time9);

            List<Order> orders= new List<Order>();
            

            for (int i = 0; i < 60; i++)
            {

               DateTime ti = new DateTime(2022, 5, 8, 16, 0, 0);
               ti = ti.AddMinutes(15 * i);
                orders.Add(new Order(i, customer, ti, true, demanded));
               
             
                Console.WriteLine(orders[i].OrderDate);
            }
            
            
            List<Timeslot> timeslots = new List<Timeslot>();
         
            timeslots.Add(new Timeslot(3, 1, time1, time2));
            timeslots.Add(new Timeslot(3, 2, time2, time3));
            timeslots.Add(new Timeslot(3, 3, time3, time4));
            timeslots.Add(new Timeslot(3, 4, time4, time5));
            timeslots.Add(new Timeslot(3, 5, time5, time6));
            timeslots.Add(new Timeslot(3, 6, time6, time7));
            timeslots.Add(new Timeslot(3, 7, time7, time8));
            timeslots.Add(new Timeslot(3, 8, time8, time9));


            
           IStrategy kitchen = new StrategyKitchenLimit(orders, timeslots);
           Context context = new Context();
           context.SetStrategy(kitchen);
           Console.WriteLine("done");

   














        }
        





        


    }
}