using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Algoritme
{
    // https://refactoring.guru/design-patterns/strategy
    // https://refactoring.guru/design-patterns/template-method/csharp/example
    public class Context
    {
        private IStrategy _strategy;
        
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }


        public List<Timeslot> SortOrders(List<IOrder> orders)
        {
            List<Timeslot> timeSlots = _strategy.Execute(orders);

            return timeSlots;
        }

        
     
        
    }
}