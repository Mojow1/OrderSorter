using System.Collections.Generic;

namespace orderSorter.Businesslogic.Algoritme
{
    public interface IStrategy
    {
        public List<Timeslot> Execute();
    }
}