using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using orderSorter.Businesslogic.Business;
using orderSorter.DatabaseMySQL;
using orderSorter.DataProviders;

namespace orderSorter.DataLayer.MySQL
{
    public class MySqlIProductRepository : DBConnection, IDataProviderIProduct
    {
        public void AddIProduct(IProduct product)
        {
            try
            {
                OpenConnection();
                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                cmd.ExecuteNonQuery(); // Nog uitzoeken wat deze precies doet
                CloseConnection();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IProduct FetchIProduct() // nog parameter en query toevoegen
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
                    string name = reader.GetString("name");
                    int weight = reader.GetInt32("weight");
                    IProduct product = new Product(id, name, weight);
                    return product;
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

        public List<IProduct> FetchAllProducts()
        {
            try
            {
                List<IProduct> products = new List<IProduct>();
                OpenConnection();
                string query = "nog bepalen";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    int weight = reader.GetInt32("weight");
                    IProduct product = new Product(id, name, weight);
                    products.Add(product);
                    return products;
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