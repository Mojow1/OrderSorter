using System.Collections.Generic;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Algoritme.ListSorter
{
    public interface IListSorter
    {
        public List<IOrder> SortList(List<IOrder> orders);
    }
}