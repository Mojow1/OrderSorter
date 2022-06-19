using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;

// https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
// https://dev.mysql.com/doc/connector-net/en/connector-net-connections-errors.html

//https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-stored-procedures.html

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
        public void Initialize()
        {
            _server = "localhost";
            _database = "ordersorter";
            _uid = "root";
            _password = "Leren-2021";
            string connectionString;

            connectionString = "SERVER=" + _server + ";" + "DATABASE=" +  _database + ";" + "UID=" + _uid + ";" 
                               + "PASSWORD=" + _password + ";" ;

            _connection = new MySqlConnection(connectionString);
        }

        // Open Connection
        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                
            }

            return false;
        }
        
        
        // Close Connection
        public  bool CloseConnection()
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

        public MySqlConnection Connection => _connection;
    }
}