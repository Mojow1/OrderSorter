namespace orderSorter
{
    public class BusyKitchen : Kitchen
    {
        private Order _order;
        private int _normalPreparationTimeInMinutes;
        private int _busyKitchenTimeLossPercentage;
        private int _priorityTimeSavingPercentage;




        public override IPreparedOrder PrepareHighPriorityOrder()
        {
            return new BusyKitchenPriorityOrder(_order, _normalPreparationTimeInMinutes, _busyKitchenTimeLossPercentage, _priorityTimeSavingPercentage);
        }

        public override IPreparedOrder PrepareNormalPriorityOrder()
        {
            return new BusyKitchenPreparedOrder(_order, _normalPreparationTimeInMinutes, _busyKitchenTimeLossPercentage);
        }
        
        
        
        // Constructor busy Kitchen High Priority Order
        public BusyKitchen(Order order, int normalPreparationTimeInMinutes, int busyKitchenTimeLossPercentage, int priorityTimeSavingPercentage)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
            _busyKitchenTimeLossPercentage = busyKitchenTimeLossPercentage;
            _priorityTimeSavingPercentage = priorityTimeSavingPercentage;
        }

        // Constructor busy Kitchen Normal Priority Order
        public BusyKitchen(Order order, int normalPreparationTimeInMinutes, int busyKitchenTimeLossPercentage)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
            _busyKitchenTimeLossPercentage = busyKitchenTimeLossPercentage;
        }
    }
}