// See https://aka.ms/new-console-template for more information

using System.Data.Common;
using System.Threading.Tasks.Dataflow;
using ConsoleTables;
using orderSorter;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DatabaseMySQL;
using orderSorter.DataLayer.MySQL;
using orderSorter.DataProviders;
using orderSorter.Mocking;


Start();

 void Start()

 {
  IDataProviderOrder orderRepository = new MockingOrders();
  IDataProviderProduct productRepository = new MockingProducts();
 Business business =new Business(orderRepository,productRepository);
 ConsoleGUI consoleGui = new ConsoleGUI(business);
 consoleGui.Main();


}
