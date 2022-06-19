using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DatabaseMySQL;
using orderSorter.DataProviders;

namespace orderSorter.DataLayer.MySQL
{
    public class MySqlOrderRepository : DBConnection, IDataProviderOrder
    {
        public MySqlOrderRepository()
        {
            Initialize();
        }

        public void AddOrder(Order order)
        {
            try
            {
                if (OpenConnection())
                {

                    string query =
                        $"INSERT INTO orders (id, orderdate, allowedendtime, priority, orderaccepted, orderweight) VALUES(\"{order.Id}\", \"{order.OrderDate}\", \"{order.AllowedEndTime}\", \"{order.Priority}\", \"{order.OrderAccepted}\", \"{order.OrderWeight}\")";
                    MySqlCommand cmd = new MySqlCommand(query, Connection);

                    // Execute command
                    cmd.ExecuteNonQuery();

                    // Close connection
                    CloseConnection();
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }



        public Order FetchOrder(int id)
        {
            try
            {
                List<Product> products = new List<Product>();
                string query1 = "SELECT * FROM products  WHERE OrderId=@id";
                MySqlCommand cmd1 = new MySqlCommand(query1, Connection);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    int id1 = reader1.GetInt32("id");
                    string name = reader1.GetString("name");
                    int weight = reader1.GetInt32("weight");
                    bool inStock = Convert.ToBoolean(reader1.GetByte("instock"));
                    Product product = new Product(id1, name, weight, inStock);
                    products.Add(product);


                }

                string query = "Nog test";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int ids = reader.GetInt32("id");
                    DateTime orderDate = reader.GetDateTime("orderdate");
                    DateTime allowedEndTime = reader.GetDateTime("allowedendtime");
                    bool priority = reader.GetBoolean("priority");
                    bool orderAccepted = reader.GetBoolean("orderAccepted");
                    int orderWeight = reader.GetInt32("orderweight");



                    //Order order = new Order(id, orderDate, allowedEndTime, priority, orderAccepted, orderWeight,
                      //  products);
                    //return order;

                }

                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }

            CloseConnection();
            return null;
        }

        public List<Order> FetchAllOrders()
        {
            try
            {
                List<Order> orders = new List<Order>();
                if (OpenConnection())
                {
                    string query = "SELECT * FROM orders";
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {


                        int id = reader.GetInt32("id");
                        DateTime orderDate = reader.GetDateTime("orderdate");
                        DateTime allowedEndTime = reader.GetDateTime("allowedendtime");
                        bool priority = reader.GetBoolean("priority");
                        bool orderAccepted = reader.GetBoolean("orderAccepted");

                        Order order = new Order(id, orderDate, allowedEndTime, priority, orderAccepted);
                        //IOrder order = new Order(id);
                        orders.Add(order);
                        
                        

                    }

                    List<Order> ordersComplete = new List<Order>();
                    for (int i = 0; i < orders.Count; i++)
                    {
                        List<Product> products = new List<Product>();
                        string query1 = "SELECT * FROM products  WHERE OrderId=@orders[i]";
                        MySqlCommand cmd1 = new MySqlCommand(query1, Connection);
                        MySqlDataReader reader1 = cmd1.ExecuteReader();
                        while (reader1.Read())
                        {
                            int id1 = reader1.GetInt32("id");
                            string name = reader1.GetString("name");
                            int weight = reader1.GetInt32("weight");
                            bool inStock = Convert.ToBoolean(reader1.GetByte("instock"));
                            Product product = new Product(id1, name, weight, inStock);
                            products.Add(product);


                        }
                        
                        ordersComplete.Add(new(orders[i].Id,orders[i].OrderDate, orders[i].AllowedEndTime, orders[i].Priority, orders[i].OrderAccepted, products));
                        
                    }
                    
                    
                    // Close Data Reader
                    reader.Close();

                    // Close Connection
                    CloseConnection();

                    // return Orders
                    return ordersComplete;

                }


            }
            catch (Exception e)
            {

                return null;
            }

            CloseConnection();
            return null;
        }






    }
}