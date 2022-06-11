// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Dataflow;
using ConsoleTables;
using DataLayerr.DataLayer.MySQL;
using orderSorter;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DatabaseMySQL;
using orderSorter.DataLayer.MySQL;
using orderSorter.DataProviders;


Start();

 void Start()
{
 MySqlOrderRepository orderRepository = new MySqlOrderRepository();
 Business business =new Business(orderRepository);
 ConsoleGUI consoleGui = new ConsoleGUI(business);
 //consoleGui.Main();

 DBConnection connect = new DBConnection();
 IDataProviderProduct products = new MySqlProductRepository();

 /*IProduct prod = new Product(15, "product15", 68, false);
 
 products.AddProduct(prod);
 
 List<IProduct> product = products.FetchAllProducts();
 
 for (int i = 0; i < product.Count; i++)
 {

  Console.WriteLine("id: "+product[i].Id+ "     naam: "+ product[i].Name + "    weight: " + product[i].Weight + "    "+ product[i].InStock);
 
  
 
 }*/
 
 
 
 Console.WriteLine(products.FetchProduct(1));





 

 //Product prod = new Product(12, "product12", 45);
 //products.AddProduct(prod);
 
 

}
