namespace orderSorter
{
    public class BusyKitchenPreparedOrder : IPreparedOrder
    {
        private Order _order;
        private int _normalPreparationTimeInMinutes; 
        private int _busyKitchenTimeLossPercentage;
        private double _preparationTimeInMinutes;

        public BusyKitchenPreparedOrder(Order order, int normalPreparationTimeInMinutes, int busyKitchenTimeLossPercentage)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
            _busyKitchenTimeLossPercentage = busyKitchenTimeLossPercentage;
        }


        // Verwerkingstijd in order zetten
        public void Prepare()
        {
            double lostMinutesKitchen = _normalPreparationTimeInMinutes * (_busyKitchenTimeLossPercentage / 100);
            _preparationTimeInMinutes = _normalPreparationTimeInMinutes + lostMinutesKitchen;
        }

        public Order Order => _order;

        public int NormalPreparationTimeInMinutes => _normalPreparationTimeInMinutes;

        public int BusyKitchenTimeLossPercentage => _busyKitchenTimeLossPercentage;

        public double PreparationTimeInMinutes => _preparationTimeInMinutes;
    }
}