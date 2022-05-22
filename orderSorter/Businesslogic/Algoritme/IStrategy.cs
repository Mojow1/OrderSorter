using System.Collections.Generic;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Algoritme
{
    public interface IStrategy
    {
        public List<Timeslot> Sort(List<Order> orders);


    }
}