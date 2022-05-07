namespace orderSorter
{
    public class PackingSlipKitchen
    {
        private Order _order;
        private int _minutesToPrepare;

        public PackingSlipKitchen(Order order, int minutesToPrepare)
        {
            _order = order;
            _minutesToPrepare = minutesToPrepare;
        }

        public Order Order => _order;

        public int MinutesToPrepare => _minutesToPrepare;
    }
}