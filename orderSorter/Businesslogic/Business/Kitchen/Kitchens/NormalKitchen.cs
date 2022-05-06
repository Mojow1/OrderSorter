namespace orderSorter
{
    public class NormalKitchen : Kitchen
    {
        public override IPriorityOrder PrepareHighPriorityOrder()
        {
            return new NormalKitchenPriorityOrder();
        }

        public override INormalOrder PrepareNormalPriorityOrder()
        {
            return new NormalKitchenNormalOrder();
        }
    }
}