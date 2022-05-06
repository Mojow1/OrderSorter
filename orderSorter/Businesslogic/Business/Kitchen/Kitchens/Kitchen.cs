using System;

namespace orderSorter
{
    public abstract class Kitchen
    {

        public abstract IPreparedOrder PrepareHighPriorityOrder();
        public abstract IPreparedOrder PrepareNormalPriorityOrder();




    }

    
}