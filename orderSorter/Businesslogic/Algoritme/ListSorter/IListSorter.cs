using System.Collections.Generic;

namespace orderSorter.Businesslogic.Algoritme.ListSorter
{
    public interface IListSorter
    {
        public List<Order> SortList(List<Order> orders);
    }
}