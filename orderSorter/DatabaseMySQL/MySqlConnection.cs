using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace orderSorter.DatabaseMySQL
{
    public class MySqlConnection
    {

        private string connString = string.Format("Server=localhost; database=; UID=root; password=Leren-2021");
        private MySqlConnection connection = null;

        public bool openConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connString);
                MySqlCommand.connection.Open();
            }
            return true;
        }


        

        public void closeConnection()
        {
            if (connection != null)
            {
                MySqlCommand.connection.Close();
                connection = null;
            }
        }

        
        
        
    }
}