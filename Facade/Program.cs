// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Dataflow;
using orderSorter;
using orderSorter.DataLayer.MySQL;


Start();

 void Start()
{
 MySqlOrderRepository orderRepository = new MySqlOrderRepository();
 Business business =new Business(orderRepository);
 ConsoleGUI consoleGui = new ConsoleGUI(business);
 consoleGui.Main();
}
