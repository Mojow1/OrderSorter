using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Bcpg;

namespace orderSorter.Businesslogic.Algoritme
{
    public class StrategyKitchenLimit : IStrategy
    {
        private List<Order> _orders;
        private List<Timeslot> _kitchenTimeslots;
        private List<PackingSlipKitchen> _packingSlipKitchens;
        private List<Order> _cancelledOrders;

        public StrategyKitchenLimit(List<Order> orders, List<Timeslot> kitchenTimeslots)
        {
            _orders = orders;
            _kitchenTimeslots = kitchenTimeslots;
        }
        public void Execute()
        {
            //check if timeslot is full yes-add to timeslot no-check next timeslot 
            //add to timeslot 
            AssignToTimeSlot();
            CalculateProcessingTime();
        }


        public void CalculateProcessingTime()
        {
            foreach (var timeslot in _kitchenTimeslots)
            {
                if (timeslot.TimeslotOrders.Count < 5)
                {
                    foreach (var order in timeslot.TimeslotOrders)
                    {
                   
                    }
                    
                    
                }

                else
                {
                    foreach (var order in timeslot.TimeslotOrders)
                    {
                   
                    }
                }
                
                
             
            }
            
        }


        public void AssignToTimeSlot()
        {
            List<Timeslot> sortedKitchenTimeslots =
                _kitchenTimeslots.OrderBy(timeslot => timeslot.TimeslotTime).ToList();

            List<Order> sortedOrders = _orders.OrderBy(o => o.OrderDate).ToList();

            foreach (var order in sortedOrders)
            {
                for (var i = 0; i < _kitchenTimeslots.Count; i++)
                {
                    if (order.OrderDate <= _kitchenTimeslots[i].Start ||
                        order.OrderDate >= _kitchenTimeslots[i].End) continue;
                    foreach (var o in sortedOrders)
                    {
                        if (sortedKitchenTimeslots[i].TimeslotMax - sortedKitchenTimeslots[i].TimeslotCurrent >= order.OrderSize)
                        {
                            sortedKitchenTimeslots[i].TimeslotOrders.Add(order);
                        }
                        else if (sortedKitchenTimeslots[i+1].TimeslotMax -
                                 sortedKitchenTimeslots[i+1].TimeslotCurrent >= order.OrderSize)
                        {
                            sortedKitchenTimeslots[i+1].TimeslotOrders.Add(order);
                        }
                        else if (sortedKitchenTimeslots[i+2].TimeslotMax -
                                 sortedKitchenTimeslots[i+2].TimeslotCurrent >= order.OrderSize)
                        {
                            sortedKitchenTimeslots[i+2].TimeslotOrders.Add(order);
                    
                        }
                        else if (sortedKitchenTimeslots[i+3].TimeslotMax -
                                 sortedKitchenTimeslots[i+3].TimeslotCurrent >= order.OrderSize)
                        {
                            sortedKitchenTimeslots[i+3].TimeslotOrders.Add(order);
                    
                        }
                        else
                        {
                            _cancelledOrders.Add(order);
                            sortedOrders.Remove(order);
                        }

                        _orders = sortedOrders;
                        _kitchenTimeslots = sortedKitchenTimeslots;
                    }
                    
                }

            }


           



        }
    }
    
    
}