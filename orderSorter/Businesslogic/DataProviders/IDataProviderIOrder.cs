using System.Collections.Generic;
using orderSorter.Businesslogic.Business;

namespace orderSorter.DataProviders
{
    public interface IDataProviderIOrder
    {
        
        public void AddIOrder(IOrder order);

        public IOrder FetchIOrder();

        public List<IOrder> FetchAllIOrders();
    }


}