using System.Collections.Generic;
using orderSorter.Businesslogic.Business;

namespace orderSorter.Businesslogic.Interfaces
{
    public interface IListSorter
    {
        public List<IOrder> SortList(List<IOrder> orders);
    }
}