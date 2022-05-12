using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Castle.Core.Internal;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Bcpg;

namespace orderSorter.Businesslogic.Algoritme
{
    public class StrategyKitchenLimit : IStrategy
    {
        private List<Order> _orders;
        private List<Timeslot> _timeslots;
        private List<Order> _cancelledOrders;
        
        

        // constructor
        public StrategyKitchenLimit(List<Order> orders, List<Timeslot> timeslots)
        {
            _orders = orders;
            _timeslots = timeslots;
            _cancelledOrders = new List<Order>();
        }
        
        // Execute method
        public List<Timeslot >Execute()
        {
           
            //check if timeslot is full yes-add to timeslot no-check next timeslot 
            //add to timeslot 
            
        List<Timeslot> lijst = AssignToTimeSlot(_orders, _timeslots);
        return lijst;
        

        }
        
        public List<Timeslot> AssignToTimeSlot(List<Order> orders, List<Timeslot> _timeslots)
        {
            
            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < _timeslots.Count; j++)
                {
                    if (orders[i].OrderDate > _timeslots[j].Start && orders[i].OrderDate < _timeslots[j].End && _timeslots[j].TimeslotMax > _timeslots[j].TimeslotOrders.Count)
                    {
                        _timeslots[j].TimeslotOrders.Add(orders[i]);
                        Console.WriteLine("addedtotimeSlot1");
                        break;
                    }
                    
                    else if (_timeslots[j + 1].TimeslotMax > _timeslots[j + 1].TimeslotOrders.Count)

                    {
                        _timeslots[j+1].TimeslotOrders.Add(orders[i]);
                        Console.WriteLine("addedtotimeSlot2");
                        break;
                        
                    }
                    
                    else if (_timeslots[j + 2].TimeslotMax > _timeslots[j + 2].TimeslotOrders.Count)

                    {
                        _timeslots[j+2].TimeslotOrders.Add(orders[i]);
                        Console.WriteLine("addedtotimeSlot3");
                        break;
                        
                    }
                    
                    else if (_timeslots[j + 3].TimeslotMax > _timeslots[j + 3].TimeslotOrders.Count)

                    {
                        _timeslots[j+3].TimeslotOrders.Add(orders[i]);
                        Console.WriteLine("addedtotimeSlot4");
                        break;
                        
                    }
                    
                    else {
                        _cancelledOrders.Add(orders[i]);
                        Console.WriteLine("addedtocancelledorder");
                        
                   break;
                    }
                }
                
            }
            return _timeslots;
        }
    }
    

    
    
    
}