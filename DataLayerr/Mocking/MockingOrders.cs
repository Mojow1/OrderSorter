using System.Collections.Generic;
using orderSorter.DataProviders;

namespace orderSorter.Mocking;

public class MockingOrders : IDataProviderOrder
{
    public void AddOrder(Order order)
    {
        throw new System.NotImplementedException();
    }

    public Order FetchOrder(int id)
    {
        throw new System.NotImplementedException();
    }

    public List<Order> FetchAllOrders()
    {
        return GetSampleOrders();
    }

    public List<Order> GetSampleOrders()
    {
        List<Order> orders = new List<Order>();

        return orders;
    }
}