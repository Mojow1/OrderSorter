namespace orderSorter
{
    public class BusyKitchen : Kitchen
    {
        public override IPriorityOrder PrepareHighPriorityOrder()
        {
            return new BusyKitchenPriorityOrder();
        }

        public override INormalOrder PrepareNormalPriorityOrder()
        {
            return new BusyKitchenNormalOrder();
        }
    }
}