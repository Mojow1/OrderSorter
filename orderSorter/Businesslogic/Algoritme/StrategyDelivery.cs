using System.Collections.Generic;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Algoritme
{
    public class StrategyDelivery : IStrategy
    {
        
        private List<Order> _orders;
        private List<Timeslot> _timeslots;
        private List<Order> _cancelledOrders;

        public StrategyDelivery(List<Timeslot> timeslots)
        {
            _timeslots = timeslots;
        }

        public List<Timeslot> Sort(List<Order> orders)
        {
            throw new System.NotImplementedException();
        }

        public List<Timeslot> TimeSlots { get; set; }
        public List<Order> Orders { get; set; }
    }
}