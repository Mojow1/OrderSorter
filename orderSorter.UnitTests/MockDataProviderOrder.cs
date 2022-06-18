using System.Collections.Generic;
using orderSorter;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DataProviders;

namespace OrderSorterUnitTest;

public class MockDataProviderOrder : IDataProviderOrder
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
        throw new System.NotImplementedException();
    }
}