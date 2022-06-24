using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions.Equivalency;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Algoritme;



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
            
            
            //Strategie 1 starten 
            _business.SetStrategy(new AssignKitchenLimitStrategy(10, 8, new DateTime(), 4));
            _business.AssignOrders(_business.Orders);
            _business.AssignStrategy.GetTimeSlots();
            _business.AssignStrategy.GetDeniedOrders();
            Console.WriteLine("Strategie 1 gedraaid");
            
            
            _business.SetStrategy(new AssignKitchenNormalStrategy(10, 8, new DateTime(), 4));
            _business.AssignOrders(_business.Orders);
            _business.AssignStrategy.GetTimeSlots();
            _business.AssignStrategy.GetDeniedOrders();
            Console.WriteLine("strategie 2 gedraaid");
            

        }



    

    }

}