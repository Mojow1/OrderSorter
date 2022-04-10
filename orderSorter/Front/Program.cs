using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using orderSorter.DatabaseMySQL;

namespace orderSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>[] list = new List<string>[2];
            DBConnection db = new DBConnection();
            db.OpenConnection();
            list = db.Select();

            Console.WriteLine();
            Console.WriteLine("Before");
            Console.WriteLine(list);
            Console.WriteLine("after");

          
            
   
            



        }

        
    }
    

    
}