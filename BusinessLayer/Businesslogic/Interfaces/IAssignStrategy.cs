using System.Collections.Generic;
using Google.Protobuf.Collections;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Interfaces
{
    public interface IAssignStrategy
    {
        public void AssignOrders(List<Order> orders);

        public List<Timeslot> GetTimeSlots();

        public List<Order> GetDeniedOrders();
  


    }
}