using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;


namespace orderSorter
{
   public class ConsoleGUI
   {

       private Business _business;
       


       public ConsoleGUI(Business business)
       {
           _business = business;
       }
       public void Main()
        {
            Console.WriteLine("START");

            //Strategie 1 starten 
            _business.OrderAssigner.SetStrategy(new AssignKitchenLimitStrategy(10,8,new DateTime(),4));
            _business.OrderAssigner.AssignOrders(_business.Orders);
            
            // Strategie 2 komt hier 
            
             
                
                _business.OrderAssigner.SetStrategy(new AssignKitchenNormalStrategy(10,8,new DateTime(),4));
                _business.OrderAssigner.AssignOrders(_business.Orders);
                
                
                _business.AssignOrders(new AssignKitchenLimitStrategy(10,8,new DateTime(),4));
             
   

            


        }
        
        public static List<IOrder> GetOrders() /// Tijdelijk, komt uiteindelijk vanuit database
        {
    

            Product p1 = new Product(1, "product1", 10, true);
            Product p2 = new Product(2, "product2", 20, true);
            Product p3 = new Product(3, "product3", 30, true);


            List<Product> products = new List<Product>();
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

       
        

    }

 
}