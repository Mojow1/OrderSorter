using System;
using System.Collections.Generic;
using orderSorter;
using orderSorter.Businesslogic.Algoritme;

namespace OrderSorterUnitTest;

public class AlgoritmeUnitTests
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
            Order order = new Order(1, customer, new DateTime(2022, 5, 8, 16, 15, 0), true, demanded);
            Order order2 = new Order(2, customer, new DateTime(2022, 5, 8, 16, 16, 0), true, demanded);
            Order order3 = new Order(3, customer, new DateTime(2022, 5, 8, 16, 17, 0), true, demanded);

            Order order4 = new Order(4, customer, new DateTime(2022, 5, 8, 16, 18, 0), true, demanded);
            Order order5 = new Order(5, customer, new DateTime(2022, 5, 8, 16, 19, 0), true, demanded);
            Order order6 = new Order(6, customer, new DateTime(2022, 5, 8, 16, 20, 0), true, demanded);

            Order order7 = new Order(7, customer, new DateTime(2022, 5, 8, 16, 21, 0), true, demanded);
            Order order8 = new Order(8, customer, new DateTime(2022, 5, 8, 16, 22, 0), true, demanded);
            Order order9 = new Order(9, customer, new DateTime(2022, 5, 8, 16, 33, 0), true, demanded);

            Order order10 = new Order(10, customer, new DateTime(2022, 5, 8, 16, 40, 0), true, demanded);

            DateTime time1 = new DateTime(2022, 5, 8, 16, 0, 0);
            DateTime time2 = new DateTime(2022, 5, 8, 17, 0, 0);
            DateTime time3 = new DateTime(2022, 5, 8, 18, 0, 0);
            DateTime time4 = new DateTime(2022, 5, 8, 19, 0, 0);
            DateTime time5 = new DateTime(2022, 5, 8, 20, 0, 0);
            DateTime time6 = new DateTime(2022, 5, 8, 21, 0, 0);
            DateTime time7 = new DateTime(2022, 5, 8, 22, 0, 0);
            DateTime time8 = new DateTime(2022, 5, 8, 23, 0, 0);
            DateTime time9 = new DateTime(2022, 5, 9, 0, 0, 0);
            
            
            

                   
           
            Timeslot timeslot2 = new Timeslot(3, 1, time2, time3, new List<Order>());
            Timeslot timeslot3 = new Timeslot(3, 2, time3, time4, new List<Order>());

            Timeslot timeslot4 = new Timeslot(3, 3, time4, time5, new List<Order>());
            Timeslot timeslot5 = new Timeslot(3, 4, time5, time6, new List<Order>());
            Timeslot timeslot6 = new Timeslot(3, 5, time6, time7, new List<Order>());
            Timeslot timeslot7 = new Timeslot(3, 6, time7, time8, new List<Order>());
            Timeslot timeslot8 = new Timeslot(3, 7, time8, time9, new List<Order>());

            List<Order> orders= new List<Order>();
            List<Order> orders2 = new List<Order>();
            List<Order> orders3 = new List<Order>();
            List<Order> orders4 = new List<Order>();
            List<Order> orders5 = new List<Order>();
            List<Order> orders6 = new List<Order>();
            List<Order> orders7 = new List<Order>();
            List<Order> orders8 = new List<Order>();
            
            
            List<Timeslot> timeslots = new List<Timeslot>();
            /*timeslots.Add(timeslot2);
            timeslots.Add(timeslot3);
            timeslots.Add(timeslot4);
            timeslots.Add(timeslot5);
            timeslots.Add(timeslot6);
            timeslots.Add(timeslot7);
            timeslots.Add(timeslot8);*/

 
            
     

            timeslots.Add(new Timeslot(3, 1, time1, time2, orders));
            timeslots.Add(new Timeslot(3, 2, time2, time3, orders2));
            timeslots.Add(new Timeslot(3, 3, time3, time4, orders3));
            timeslots.Add(new Timeslot(3, 4, time4, time5, orders4));
            timeslots.Add(new Timeslot(3, 5, time5, time6, orders5));
            timeslots.Add(new Timeslot(3, 6, time6, time7, orders6));
            timeslots.Add(new Timeslot(3, 7, time7, time8, orders7));
            timeslots.Add(new Timeslot(3, 8, time8, time9, orders8));

            orders.Add(order);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);
            orders.Add(order5);
            orders.Add(order6);
            orders.Add(order7);
            orders.Add(order8);
            orders.Add(order9);
            orders.Add(order10);


            
            IStrategy kitchen = new StrategyKitchenLimit(orders, timeslots);
            Context context = new Context();
            List<Timeslot> calculated = context.SetStrategy(kitchen);


            foreach (var VARIABLE in calculated)
            {
                Console.WriteLine(    VARIABLE.TimeslotOrders.Count
                    );
            
            }


       
}