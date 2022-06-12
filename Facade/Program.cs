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
 MySqlProductRepository productRepository = new MySqlProductRepository();
 Business business =new Business(orderRepository,productRepository);
 ConsoleGUI consoleGui = new ConsoleGUI(business);
 //consoleGui.Main();

 DBConnection connect = new DBConnection();
 IDataProviderProduct products = new MySqlProductRepository();
 Database data = new Database();
 IProduct prod = new Product(16, "product16", 200, false);
 
 products.AddProduct(prod);
 
 List<IProduct> product = products.FetchAllProducts();
 
 for (int i = 0; i < product.Count; i++)
 {

  Console.WriteLine("id: "+product[i].Id+ "     naam: "+ product[i].Name + "    weight: " + product[i].Weight + "    "+ product[i].InStock);
 
  
 
 }

 /*IProduct product = products.FetchProduct(1);
 IProduct product2 = products.FetchProduct(2);
 IProduct product3 = products.FetchProduct(3);

 Console.WriteLine(product.Id + "   "+  product.Name + "   "+ product.Weight+ "   "+ product.InStock);
 Console.WriteLine(product2.Id + "   "+  product2.Name + "   "+ product2.Weight+ "   "+ product2.InStock);
 Console.WriteLine(product3.Id + "   "+  product3.Name + "   "+ product3.Weight+ "   "+ product3.InStock);*/





 

 //Product prod = new Product(12, "product12", 45);
 //products.AddProduct(prod);
 
 

}
