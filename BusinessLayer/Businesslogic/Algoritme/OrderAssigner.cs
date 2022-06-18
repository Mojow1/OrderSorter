using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Algoritme
{
    // https://refactoring.guru/design-patterns/assignStrategy
    // https://refactoring.guru/design-patterns/template-method/csharp/example
    public class OrderAssigner
    {
        private IAssignStrategy _assignStrategy;
        
        public void SetStrategy(IAssignStrategy assignStrategy)
        {
            _assignStrategy = assignStrategy;
        }


        public void  AssignOrders(List<Order> orders)
        {
           _assignStrategy.AssignOrders(orders);
           
        }

        public IAssignStrategy AssignStrategy
        {
            get => _assignStrategy;
        }
        
        
    }
}