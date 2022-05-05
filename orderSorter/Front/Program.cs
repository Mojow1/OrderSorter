using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using orderSorter.DatabaseMySQL;

namespace orderSorter
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {

            Product p1 = new Product(1, "product1", 10);
            Product p2 = new Product(2, "product2", 20);
            Product p3 = new Product(3, "product3", 30);

            ProductQuantity s1 = new ProductQuantity(p1, 4);
            ProductQuantity s2 = new ProductQuantity(p2, 0);
            ProductQuantity s3 = new ProductQuantity(p3, 6);

            List<ProductQuantity> stockQuantity = new List<ProductQuantity>();
            stockQuantity.Add(s1);
            stockQuantity.Add(s2);
            stockQuantity.Add(s3);
            
            Stock stock = new Stock(stockQuantity);
            
            
            foreach (var lijst in stock.ProductsQuantity)
            {
                //Console.WriteLine(lijst.Product.Id, "lijst.Product.Name , lijst.Product.Price);
                Console.WriteLine("naam:" + lijst.Product.Name + "  id:" + lijst.Product.Id + "  prijs:" + lijst.Product.Price 
                + "  Voorraad:" + lijst.Quantity + " stuks");            
                
            }


            Priority priority = new Priority(true);
            Customer customer = new Customer(1, "voornaam", "achternaam", "Straatnaam", 52, "6164VT", "Geleen");
            DateTime orderTime = DateTime.Now;

            ProductQuantity product1 = new ProductQuantity(p1, 4);
            ProductQuantity product2 = new ProductQuantity(p2, 0);
            ProductQuantity product3 = new ProductQuantity(p3, 7);

            List<ProductQuantity> demanded = new List<ProductQuantity>();
            demanded.Add(product1);
            demanded.Add(product2);
            demanded.Add(product3);

            Order order = new Order(1, customer, orderTime, priority, demanded);

            StockChecker stockChecker = new StockChecker(order, stock);
            Console.WriteLine();
            Console.WriteLine(stockChecker.CheckStock());










        }

        
    }
    

    
}