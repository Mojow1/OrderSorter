namespace orderSorter
{
    public class Stock
    {
        private Product _product;
        private int _quantity;

        public Stock(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public Product Product => _product;

        public int Quantity => _quantity;
    }
}