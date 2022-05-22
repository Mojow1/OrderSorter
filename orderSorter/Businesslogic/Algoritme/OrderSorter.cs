using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Algoritme
{
    public class OrderSorter
    {
        private IStrategy _strategy;


        public List<Timeslot> SortOrders(List<Order> orders)
        {
            List<Timeslot> timeSlots = _strategy.Sort(orders);

            return timeSlots;
        }

        
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        
    }
}