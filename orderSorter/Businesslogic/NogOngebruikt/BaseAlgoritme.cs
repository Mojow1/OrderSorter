using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Algoritme
{
    public abstract class BaseAlgoritme
    {
        // Stap 2 aanmaken van tijdslots
        // Stap 1 laden van orders
        // stap 2 bepalen sorteer methode voor keuken
        // stap 3 sorteer orders voor keuken
        // stap 4 Leeg geannuleerde orderlijst keuken
        // stap 5 

        public List<Timeslot> GenerateTimeSlots() // stap 1 aanmaken tijdslots
        {
            List<Timeslot> timeSlots = new List<Timeslot>();
            DateTime time = new DateTime(2022, 5, 8, 16, 0, 0);
            for (int i = 0; i < 8; i++)
            {
                timeSlots.Add(new Timeslot( 3,i+1 ,time, time.AddHours(1)));
                time = time.AddHours(1);
            }

            return timeSlots;
        }

        public List<IOrder> GetIOrders() // stap 2 aanmaken van orders
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


        abstract public List<IOrder> SortOrders(); // Stap 3 sorteer orders naar grootte of tijdstip etc

        abstract public List<Timeslot> AssignIOrders(); // stap 4 wijs orders toe aan tijdsloten
        
        




    }
}