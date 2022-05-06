namespace orderSorter
{
    public class NormalKitchen : Kitchen
    {
        private Order _order;
        private int _normalPreparationTimeInMinutes;
        private int _priorityTimeSavingPercentage;
        
        
                
        // Constructor Normal Kitchen High Priority
        public NormalKitchen(Order order, int normalPreparationTimeInMinutes, int priorityTimeSavingPercentage)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
            _priorityTimeSavingPercentage = priorityTimeSavingPercentage;
        }
        
        // Constructor Normal Kitchen Normal Order
        public NormalKitchen(Order order, int normalPreparationTimeInMinutes)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
        }
        
        public override IPreparedOrder PrepareHighPriorityOrder()
        {
            return new NormalKitchenPriorityOrder(_order,_normalPreparationTimeInMinutes,_priorityTimeSavingPercentage);
        }

        public override IPreparedOrder PrepareNormalPriorityOrder()
        {
            return new NormalKitchenNormalPriority(_order, _normalPreparationTimeInMinutes);
        }

        public Order Order => _order;

        public int NormalPreparationTimeInMinutes => _normalPreparationTimeInMinutes;

        public int PriorityTimeSavingPercentage => _priorityTimeSavingPercentage;
    }
}