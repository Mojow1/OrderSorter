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

        public void AddOrder(IOrder order)
        {
            try
            {
                if (OpenConnection() )
                {
                    
                    string query = $"INSERT INTO orders (id, orderdate, allowedendtime, priority, orderaccepted, orderweight) VALUES(\"{order.Id}\", \"{order.OrderDate}\", \"{order.AllowedEndTime}\", \"{order.Priority}\", \"{order.OrderAccepted}\", \"{order.OrderWeight}\")";
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



        public IOrder FetchOrder(int id)
        {
            try
            {
              
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
                    List<IProduct> products = new List<IProduct>(); // nog fixen ophalen lijst producten

                    IOrder order = new Order(id, orderDate, allowedEndTime, priority, orderAccepted, orderWeight, products);
                    return order;

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

        public List<IOrder> FetchAllOrders()
        {
            try
            {
                //List<IProduct> products = new List<IProduct>();
                List<IOrder> orders = new List<IOrder>();

                if (OpenConnection())
                {
                    string query = "SELECT * FROM 'ordersorter'.'orders'";
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
              
                    
                        int id = reader.GetInt32("id");
                        DateTime orderDate = reader.GetDateTime("orderdate");
                        DateTime allowedEndTime = reader.GetDateTime("allowedendtime");
                        bool priority = reader.GetBoolean("priority");
                        bool orderAccepted = reader.GetBoolean("orderAccepted");
                        int orderWeight = reader.GetInt32("orderweight");
                        List<IProduct> products = new List<IProduct>(); // nog fixen ophalen lijst producten

                       // IOrder order = new Order(id, orderDate, allowedEndTime, priority, orderAccepted, orderWeight, products);
                        //IOrder order = new Order(id);
                        // orders.Add(order);
        
                    }
                    // Close Data Reader
                    reader.Close();
                    
                    // Close Connection
                    CloseConnection();
                    
                    // return Orders
                    return orders;

                }
                
               
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            CloseConnection();
            return null;
        }






    }
}