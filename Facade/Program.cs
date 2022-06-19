﻿// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Dataflow;
using ConsoleTables;
using orderSorter;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DatabaseMySQL;
using orderSorter.DataLayer.MySQL;
using orderSorter.DataProviders;


Start();

 void Start()
{
 MySqlOrderRepository orderRepository = new MySqlOrderRepository();
 //MySqlProductRepository productRepository = new MySqlProductRepository();
 //Business business =new Business(orderRepository,productRepository);
 //ConsoleGUI consoleGui = new ConsoleGUI(business);
 //consoleGui.Main();

 List<Order> orders = new List<Order>();

 orders = orderRepository.FetchAllOrders();


 for (int i = 0; i < orders.Count; i++)
 {
  Console.WriteLine(orders[i].Id);
 }
}
