namespace orderSorter
{
    public class OrderDetails
    {
        private Product product;
        private int quantity;
     

        public OrderDetails(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        
        public Product Product1 => product;

        public int Quantity1 => quantity;
    }
}