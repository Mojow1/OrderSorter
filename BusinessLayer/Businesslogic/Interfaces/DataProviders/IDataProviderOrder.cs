using System.Collections.Generic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.DataProviders
{
    public interface IDataProviderOrder
    {
        
        public void AddOrder(Order order);

        public Order FetchOrder(int id);

        public List<Order> FetchAllOrders();
    }


}