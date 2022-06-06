using System;
using System.Collections.Generic;
using System.Linq;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;
using Org.BouncyCastle.Crypto.Parameters;

namespace orderSorter.Businesslogic.Algoritme.ListSorter
{
    public class SortsBySize : IListSorter
    {
        public List<IOrder> SortList(List<IOrder> orders)
        {

            List<IOrder> test = new List<IOrder>();
            orders.OrderBy(x => x.OrderDate).ThenBy(x => x.OrderWeight).ToList();
            
            
            
            /*orders.Sort(delegate(IOrder order1, IOrder order2)
            {
                int r = order1.OrderDate.Day.CompareTo(order2.OrderDate.Day);
                if (r == 0) r = order2.OrderWeight.CompareTo(order1.OrderWeight);
                if (r == 0) r = order1.OrderDate.Hour.CompareTo(order2.OrderDate.Hour);
               
                return r;
            });*/

            return orders;
        }
    }
}