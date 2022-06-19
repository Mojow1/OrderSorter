// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Dataflow;
using ConsoleTables;
using orderSorter;
using orderSorter.Businesslogic.Algoritme;
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

 DateTime date = new DateTime(2022, 5, 8, 16, 0, 0);
 AssignKitchenLimitStrategy kitchen = new AssignKitchenLimitStrategy(60, 8, date, 4);
 int  numberOfTimeSlots = (60 / 60) * 8;

 Console.WriteLine(kitchen.GetTimeSlots().Count);
 Console.WriteLine(numberOfTimeSlots);

 for (int i = 0; i <kitchen.GetTimeSlots().Count; i++)
 {
  Console.WriteLine(kitchen.GetTimeSlots()[i].Start+ "     "+ kitchen.GetTimeSlots()[i].End);
 }
}
