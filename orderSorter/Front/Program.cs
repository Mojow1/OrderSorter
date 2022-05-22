using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Algoritme.ListSorter;
using orderSorter.Businesslogic.Business;
using orderSorter.DatabaseMySQL;

namespace orderSorter
{
    class Program
    {
        // Eventueel pakbon en/of rit toevoegen aan Delivery map
        // sorteren op tijd en op grootte en wellicht rekening houden met volume
        static void Main(string[] args)
        {
            List<Order> orders = GetOrders();

            IListSorter sortedByDate = new SortsByDate();
            List<Order> sorted =  sortedByDate.SortList(orders);

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine("Id: " +sorted[i].Id + "   date:"+ sorted[i].OrderDate + "   price:" + sorted[i].TotalPrice);
            }



            /*List<Timeslot> timeSlots = GetTimeSlots();
            
             OrderSorter orderSorter = new OrderSorter();
            IStrategy kitchen = new StrategyKitchenLimit(timeSlots);


            orderSorter.SetStrategy(kitchen); 
            List<Timeslot> slots =   orderSorter.SortOrders(orders);

            for (int i = 0; i < slots.Count; i++)
            {
                for (int j = 0; j < slots[i].TimeslotOrders.Count; j++)
                {
                    Console.WriteLine("slot:"+ i + "       order:" + slots[i].TimeslotOrders[j].Id );
                }
            }*/

        }
        
        public static List<Order> GetOrders()
        {
            Customer customer = new Customer(1, "voornaam", "achternaam", "Straatnaam", 52, "6164VT", "Geleen");

            Product p1 = new Product(1, "product1", 10);
            Product p2 = new Product(2, "product2", 20);
            Product p3 = new Product(3, "product3", 30);

            Dictionary<Product, int> products = new Dictionary<Product, int>()
            {
                {p1,4},
                {p2,0},
                 {p3,7}

            };
            
            Dictionary<Product, int> products2 = new Dictionary<Product, int>()
            {
                {p1,3},
                {p2,8},
                {p3,4}

            };




                // orders
            List<Order> orders= new List<Order>();
          
            for (int i = 0; i <30; i++)
            {
                DateTime ti = new DateTime(2022, 5, 8, 16, 0, 0);
                ti = ti.AddMinutes(15 * i);
                orders.Add(new Order(i+1, customer, ti, true, products));
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