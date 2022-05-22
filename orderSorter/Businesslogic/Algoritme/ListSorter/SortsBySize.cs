using System;
using System.Collections.Generic;

namespace orderSorter.Businesslogic.Algoritme.ListSorter
{
    public class SortsBySize : IListSorter
    {
        public List<Order> SortList(List<Order> orders)
        {
            orders.Sort((x,y) =>
            {
                var ret = x.OrderDate.Hour.CompareTo(y.OrderDate.Hour);
                
                if (ret == 0) ret = y.TotalPrice.CompareTo(x.TotalPrice);
                {
                    
                    return ret;
                }});
            
            Console.WriteLine();
            Console.WriteLine();
            
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine(orders[i].OrderDate + "     size: "+ orders[i].TotalPrice);
                
            }

            return orders;
        }
    }
}