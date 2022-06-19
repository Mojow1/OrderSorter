using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;


namespace orderSorter
{
   public class ConsoleGUI
   {

       private Business _business;
       


       public ConsoleGUI(Business business)
       {
           _business = business;
       }
       public void Main()
        {
            Console.WriteLine("START");

            //Strategie 1 starten 
            _business.SetStrategy(new AssignKitchenLimitStrategy(10,8,new DateTime(),4));
            _business.AssignOrders(_business.Orders);
            _business.AssignStrategy.GetTimeSlots();
            _business.AssignStrategy.GetDeniedOrders();
            
            
            
            // Strategie 2 komt hier 
            
                _business.SetStrategy(new AssignKitchenNormalStrategy(10,8,new DateTime(),4));
                _business.AssignOrders(_business.Orders);
                _business.AssignStrategy.GetTimeSlots();
                _business.AssignStrategy.GetDeniedOrders();
                
                
        }
       

    }

 
}