using System.Collections.Generic;
using Google.Protobuf.Collections;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Algoritme
{
    public interface IStrategy
    {
        public List<Timeslot> Execute(List<IOrder> orders);


    }
}