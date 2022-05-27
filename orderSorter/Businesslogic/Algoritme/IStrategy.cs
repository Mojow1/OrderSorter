using System.Collections.Generic;
using Google.Protobuf.Collections;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Algoritme
{
    public interface IStrategy
    {
        public List<Timeslot> Execute(List<IOrder> orders);
        
        public List<IOrder> GetCancelledOrders();
        public void CleanOrders(); // makes the Orderlist & the cancelledorderslist in the strategykitchen class emty


    }
}