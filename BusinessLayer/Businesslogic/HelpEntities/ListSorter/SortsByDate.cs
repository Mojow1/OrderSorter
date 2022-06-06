using System.Collections.Generic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Algoritme.ListSorter
{
    public class SortsByDate : IListSorter
    {
        public List<IOrder> SortList(List<IOrder> orders)
        {
            orders.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));
            return orders;
        }
    }
}