namespace orderSorter
{
    public class NormalKitchenPriorityOrder : IPreparedOrder
    {
        private Order _order;
        private int _normalPreparationTimeInMinutes;
        private int _priorityTimeSavingPercentage;
        private double _preparationTimeInMinutes;

        public NormalKitchenPriorityOrder(Order order, int normalPreparationTimeInMinutes, int priorityTimeSavingPercentage)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
            _priorityTimeSavingPercentage = priorityTimeSavingPercentage;
       
        }

        // Verwerkingstijd in order zetten
        public void Prepare()
        {
            double savedMinutesPriority = _normalPreparationTimeInMinutes * (_priorityTimeSavingPercentage / 100);
            _preparationTimeInMinutes = _normalPreparationTimeInMinutes - savedMinutesPriority;
            
        }

        public Order Order => _order;

        public int NormalPreparationTimeInMinutes => _normalPreparationTimeInMinutes;

        public int PriorityTimeSavingPercentage => _priorityTimeSavingPercentage;

        public double PreparationTimeInMinutes => _preparationTimeInMinutes;
    }
}

