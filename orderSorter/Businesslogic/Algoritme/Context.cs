using System.Collections.Generic;

namespace orderSorter.Businesslogic.Algoritme
{
    public class Context
    {
        private IStrategy _strategy;

        public List<Timeslot> SetStrategy(IStrategy strategy)
        {
            
            return strategy.Execute();
        }
       
    }
}