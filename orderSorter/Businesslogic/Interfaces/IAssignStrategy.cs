using System.Collections.Generic;
using Google.Protobuf.Collections;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Interfaces
{
    public interface IAssignStrategy
    {
        public void AssignOrders(List<IOrder> orders, List<Timeslot> timeslots);

        public List<Timeslot> GetTimeSlots();

        public List<IOrder> GetCancelledOrders();
        public void CleanOrders(); // makes the Orderlist & the cancelledorderslist in the strategykitchen class emty


    }
}