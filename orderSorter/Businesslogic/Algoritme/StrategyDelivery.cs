using System.Collections.Generic;

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

        public List<Timeslot> Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}