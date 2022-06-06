using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DatabaseMySQL;
using orderSorter.DataProviders;

namespace orderSorter.DataLayer.MySQL
{
    public class MySqlOrderRepository : DBConnection, IDataProviderIOrder
    {
        public void AddIOrder(IOrder order)
        {
            try
            {
                OpenConnection();
                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                cmd.ExecuteNonQuery(); 
                CloseConnection();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IOrder FetchIOrder()
        {
            try
            {
                OpenConnection();
                string query = "Nog test";
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

        public List<IOrder> FetchAllIOrders()
        {
            try
            {
                //List<IProduct> products = new List<IProduct>();

                List<IOrder> orders = new List<IOrder>();
                OpenConnection();
                string query = "nog bepalen";
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

                    IOrder order = new Order(id, orderDate, allowedEndTime, priority, orderAccepted, orderWeight, products);
                    orders.Add(order);
                    return orders;
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
    }
}