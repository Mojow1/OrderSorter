namespace orderSorter
{
    public class BusyKitchenPriorityOrder : IPreparedOrder
    {
        
        private Order _order;
        private int _normalPreparationTimeInMinutes;
        private int _busyKitchenTimeLossPercentage;
        private int _priorityTimeSavingPercentage;
        private double _preparationTimeInMinutes;

        public BusyKitchenPriorityOrder(Order order, int normalPreparationTimeInMinutes, int busyKitchenTimeLossPercentage, int priorityTimeSavingPercentage)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
            _busyKitchenTimeLossPercentage = busyKitchenTimeLossPercentage;
            _priorityTimeSavingPercentage = priorityTimeSavingPercentage;
          
        }

        // Verwerkingstijd in order zetten
        public void Prepare()
        {
            double savedMinutesPriority = _normalPreparationTimeInMinutes * (_priorityTimeSavingPercentage / 100);
            double lostMinutesKitchen = _normalPreparationTimeInMinutes * (_busyKitchenTimeLossPercentage / 100);
            _preparationTimeInMinutes = _normalPreparationTimeInMinutes - savedMinutesPriority + lostMinutesKitchen;
        }
        
        public Order Order => _order;

        public int BusyKitchenTimeLossPercentage => _busyKitchenTimeLossPercentage;

        public int PriorityTimeSavingPercentage => _priorityTimeSavingPercentage;

        public int NormalPreparationTimeInMinutes => _normalPreparationTimeInMinutes;

        public double PreparationTimeInMinutes => _preparationTimeInMinutes;


   
    }
}