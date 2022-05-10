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
        private List<PackingSlipKitchen> _packingSlipKitchens;
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
            
        return AssignToTimeSlot(_orders);
          // return CalculateProcessingTime(assignedTimeSlots);

        }

        public List<Timeslot> CalculateProcessingTime(List<Timeslot> assignedTimeslots)
        {
            int preparingTime = 0;
            foreach (var timeslot in assignedTimeslots)
            {
          
                    foreach (var order in timeslot.TimeslotOrders)
                    {
                        if (order.OrderDate < timeslot.End && order.OrderDate > timeslot.Start)
                        {
                            PackingSlipKitchen packingSlip = new PackingSlipKitchen(order.OrderDate, preparingTime);
                            order.PackingSlipKitchen = packingSlip;
                        }
                        
                        else if (order.OrderDate < timeslot.Start)
                        {
                            int waitingTimeKitchen = timeslot.Start.Minute - order.OrderDate.Minute;
                            PackingSlipKitchen packingSlip = new PackingSlipKitchen(timeslot.Start, preparingTime + waitingTimeKitchen);
                        }
                    }

            }

            return assignedTimeslots;
        }


        public List<Timeslot> AssignToTimeSlot(List<Order> orders )
        { 
          

            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < _timeslots.Count; j++)
                {
                    if (orders[i].OrderDate > _timeslots[j].Start && orders[i].OrderDate < _timeslots[j].End && _timeslots[j].TimeslotOrders.Count < _timeslots[j].TimeslotMax )
                    {
                        _timeslots[j].TimeslotOrders.Add(orders[i]);
                        Console.WriteLine("addedtotime");
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