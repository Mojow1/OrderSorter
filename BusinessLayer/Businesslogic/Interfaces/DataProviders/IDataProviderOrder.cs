using System.Collections.Generic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.DataProviders
{
    public interface IDataProviderOrder
    {
        
        public void AddOrder(IOrder order);

        public IOrder FetchOrder(int id);

        public List<IOrder> FetchAllOrders();
    }


}