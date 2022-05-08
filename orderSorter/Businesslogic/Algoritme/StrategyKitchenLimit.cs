using System;
using System.Collections.Generic;
using System.Linq;
using Castle.Core.Internal;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Bcpg;

namespace orderSorter.Businesslogic.Algoritme
{
    public class StrategyKitchenLimit : IStrategy
    {
        private List<Order> _orders;
        private List<Timeslot> _sortedKitchenTimeslots;
        private List<PackingSlipKitchen> _packingSlipKitchens;
        private List<Order> _cancelledOrders;
        
        

        // constructor
        public StrategyKitchenLimit(List<Order> orders, List<Timeslot> sortedKitchenTimeslots)
        {
            _orders = orders;
            _sortedKitchenTimeslots = sortedKitchenTimeslots;
        }
        
        
        
        
        
        // Execute method
        public List<Timeslot >Execute()
        {
           
            //check if timeslot is full yes-add to timeslot no-check next timeslot 
            //add to timeslot 
            
            List<Timeslot> assignedTimeSlots = AssignToTimeSlot();
           return CalculateProcessingTime(assignedTimeSlots);

       
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


        public List<Timeslot> AssignToTimeSlot()
        {
            
            List<Timeslot> sortedKitchenTimeslots =
               _sortedKitchenTimeslots.OrderBy(timeslot => timeslot.TimeslotTime).ToList();

            List<Order> sortedOrders = _orders.OrderBy(o => o.OrderDate).ToList();
            
 
            for (int i = 0; i < _sortedKitchenTimeslots.Count; i++)
            {
                
                for (int j = 0; j < _orders.Count; j++)
                {
                    if (_orders[j].OrderDate > _sortedKitchenTimeslots[i].Start && _orders[j].OrderDate < _sortedKitchenTimeslots[i].End
                        && _sortedKitchenTimeslots[i].TimeslotOrders.Count < _sortedKitchenTimeslots[i].TimeslotMax)
                    {
                        if (_sortedKitchenTimeslots[i].TimeslotOrders.IsNullOrEmpty())
                        {
                            new List<Order>().Add(_orders[1]);
              
                        }

                        else
                        {
                            _sortedKitchenTimeslots[i].TimeslotOrders.Add(_orders[1]);
                        }
                        
                     
                    }
                    
                    

                    else
                    {
                        //_cancelledOrders.Add(_orders[i]);
                    }
                }
                
            }
            

            return _sortedKitchenTimeslots;



        }
    }
    
    
}