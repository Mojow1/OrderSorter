namespace orderSorter.DatabaseMySQL
{
    public class MySqlDataBase
    {
        private MySqlCustomerRepository _customerRepository;
        private MySqlDelivererRepository _delivererRepository;
        private MySqlOrderRepository _orderRepository;
        private MySqlProductRepository _productRepository;
        private MySqlVehicleRepository _vehicleRepository;

        public MySqlDataBase(MySqlCustomerRepository customerRepository, MySqlDelivererRepository delivererRepository, MySqlOrderRepository orderRepository, MySqlProductRepository productRepository, MySqlVehicleRepository vehicleRepository)
        {
            _customerRepository = customerRepository;
            _delivererRepository = delivererRepository;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _vehicleRepository = vehicleRepository;
        }
    }
}