using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using orderSorter.DatabaseMySQL;

namespace orderSorter
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {

            Kitchen highWorkLoadKitchen = new BusyKitchen();
            IPriorityOrder kitchenHighPriorityHigh = highWorkLoadKitchen.PrepareHighPriorityOrder();
            INormalOrder kitchenHighPriorityNormal = highWorkLoadKitchen.PrepareNormalPriorityOrder();

            Kitchen normalWorkLoadKitchen = new NormalKitchen();
            IPriorityOrder kitchenNormalPriorityHigh = normalWorkLoadKitchen.PrepareHighPriorityOrder();
            INormalOrder kitchenNormalPriorityNormal =
                normalWorkLoadKitchen.PrepareNormalPriorityOrder();
            
            









        }

        
    }
    

    
}