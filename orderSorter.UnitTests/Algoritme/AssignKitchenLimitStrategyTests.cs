using System;
using System.Collections.Generic;
using NUnit.Framework;
using orderSorter;

namespace OrderSorterUnitTest;

[TestFixture]
public class AssignKitchenLimitStrategyTests
{



    List<Order> GetSampleOrders()
    {
        List<Order> output = new List<Order>();
        List<Product> products = new List<Product>();


        for (int i = 0; i < 5; i++)
        {
            products.Add(new Product(i,$"product{i}", i, true));
        }
        
        
        
        
        Product p1 = new Product(1, "product1", 10, true);
        Product p2 = new Product(2, "product2", 20, true);
        Product p3 = new Product(3, "product3", 30, true);


        
        products.Add(p1);
        products.Add(p2);
        products.Add(p3);
        products.Add(p3);
        products.Add(p3);


        List<Product> products2 = new List<Product>();
        products2.Add(p1);
        products2.Add(p2);
        products2.Add(p3);
            
        List<Product> products3 = new List<Product>();
        products3.Add(p1);
        products3.Add(p2);
        products3.Add(p2);
        products3.Add(p2);
            
         


        // orders
        List<Order> orders= new List<Order>();
          
            
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








        return output;
    }
}