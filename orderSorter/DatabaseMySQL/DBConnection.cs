using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;

// https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL

namespace orderSorter.DatabaseMySQL
{
    public class DBConnection
    {
        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _uid;
        private string _password;
        
        //Constructor
        public DBConnection()
        {
           Initialize();
        }

        // Intiialize values
        private void Initialize()
        {
            _server = "localhost";
            _database = "ordersorter";
            _uid = "root";
            _password = "Leren-2021";
            string connectionString;

            connectionString = "SERVER=" + _server + ";" + "DATABASE=" +  _database + ";" + "UID=" + _uid + ";" 
                               + "PASSWORD=" + _password + ";";

            _connection = new MySqlConnection(connectionString);
        }

        // Open Connection
        public  bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Cannot connect to server.  Contact administrator");
                
            }

            return false;
        }
        
        // Close Connection
        private bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return false;
        }
        
        public List<string>[] Select()
        {
            string query = "SELECT naam FROM customers ";

            List<string>[] list = new List<string>[2];

            DBConnection db = new DBConnection();

            if (db.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add((dataReader["id"]+ ""));
                    list[1].Add((dataReader["naam"]+ " "));
                }
            
                dataReader.Close();

                CloseConnection();

                return list;
                
            }

            else
            {
                return list;
            }
            
        }


       
        
        
        
        
        
        

        






    }
}