namespace orderSorter
{
    public class NormalKitchenNormalPriority : IPreparedOrder
    {
        private Order _order;
        private int _normalPreparationTimeInMinutes;
        private int _PreparationTimeInMinutes;


        public NormalKitchenNormalPriority(Order order, int normalPreparationTimeInMinutes)
        {
            _order = order;
            _normalPreparationTimeInMinutes = normalPreparationTimeInMinutes;
        }


        // Verwerkingstijd in order zetten nog check wat te doen met deze variablene
        public void Prepare()
        {
            _PreparationTimeInMinutes = _normalPreparationTimeInMinutes;
        }

        public Order Order => _order;

        public int NormalPreparationTimeInMinutes => _normalPreparationTimeInMinutes;

        public int PreparationTimeInMinutes => _PreparationTimeInMinutes;
    }
}