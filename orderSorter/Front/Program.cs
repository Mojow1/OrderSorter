using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Algoritme.ListSorter;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DatabaseMySQL;

namespace orderSorter
{
    class Program
    {
        // Eventueel pakbon en/of rit toevoegen aan Delivery map
        // sorteren op tijd en op grootte en wellicht rekening houden met volume
        static void Main(string[] args)
        {
            List<IOrder> orders = GetOrders();

            //List<Order> ord = orders.Cast<Order>().ToList();

            //var or = ord.Cast<IOrder>().ToList();
            
            
            





            //IListSorter sortedByDate = new SortsByDate();
            //List<IOrder> sorted =  sortedByDate.SortList(orders);

            IListSorter sortedBySize = new SortsBySize();
            List<IOrder> sorted = sortedBySize.SortList(orders);

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine("Id: " +sorted[i].Id + "   date:"+ sorted[i].OrderDate + "   price:" + sorted[i].OrderWeight);
            }



            List<Timeslot> timeSlots = GetTimeSlots();
            
           
            
            
            IAssignStrategy kitchen = new AssignKitchenLimitStrategy();

            OrderAssigner orderAssigner = new OrderAssigner();

            orderAssigner.SetStrategy(kitchen);
            orderAssigner.AssignOrders(orders,timeSlots);
            kitchen.GetCancelledOrders();


            List<Timeslot> slots = kitchen.GetTimeSlots();

            for (int i = 0; i < slots.Count; i++)
            {
                for (int j = 0; j < slots[i].TimeslotOrders.Count; j++)
                {
                    Console.WriteLine("slot:"+ i + "       order:" + slots[i].TimeslotOrders[j].Id );
                }
            }
          
            
            
        }
        
        public static List<IOrder> GetOrders()
        {
            Customer customer = new Customer(1, "voornaam", "achternaam", "Straatnaam", 52, "6164VT", "Geleen");

            Product p1 = new Product(1, "product1", 10);
            Product p2 = new Product(2, "product2", 20);
            Product p3 = new Product(3, "product3", 30);


            List<IProduct> products = new List<IProduct>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p3);
            products.Add(p3);


            List<IProduct> products2 = new List<IProduct>();
            products2.Add(p1);
            products2.Add(p2);
            products2.Add(p3);
            
            List<IProduct> products3 = new List<IProduct>();
            products3.Add(p1);
            products3.Add(p2);
            products3.Add(p2);
            products3.Add(p2);
            
         


                // orders
            List<IOrder> orders= new List<IOrder>();
          
            for (int i = 0; i <20; i++)
            {
                DateTime ti = new DateTime(2022, 5, 8, 16, 0, 0);
                ti = ti.AddMinutes(7 * i);
                orders.Add(new Order(i+1, ti,ti.AddHours(2) , true, products));
                ti = ti.AddMinutes(9 * i);
                orders.Add(new Order(i+1, ti,ti.AddHours(2) , true, products2));
                ti = ti.AddMinutes(12 * i);
                orders.Add(new Order(i+1, ti,ti.AddHours(2) , true, products3));
                
                
            }

            return orders;
        }

        public static List<Timeslot> GetTimeSlots()
        {
            // timeslots
            List<Timeslot> timeSlots = new List<Timeslot>();
            DateTime time = new DateTime(2022, 5, 8, 16, 0, 0);
            for (int i = 0; i < 8; i++)
            {
                timeSlots.Add(new Timeslot( 3,i+1 ,time, time.AddHours(1)));
                time = time.AddHours(1);
            }

            return timeSlots;
        }
        

    }

 
}