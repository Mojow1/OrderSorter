using System.Collections.Generic;

namespace orderSorter.Businesslogic.Algoritme.ListSorter
{
    public class SortsByDate : IListSorter
    {
        public List<Order> SortList(List<Order> orders)
        {
            orders.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));
            return orders;
        }
    }
}