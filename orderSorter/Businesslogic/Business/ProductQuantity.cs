namespace orderSorter
{
    public class ProductQuantity
    {
        private Product _product;

        public ProductQuantity(Product product, int quantity)
        {
            _product = product;
            Quantity = quantity;
        }

        public Product Product => _product;

        public int Quantity { get; }
    }
}