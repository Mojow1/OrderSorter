using System;

namespace orderSorter
{
    public abstract class Kitchen
    {

        public abstract IPriorityOrder PrepareHighPriorityOrder();
        public abstract INormalOrder PrepareNormalPriorityOrder();




    }

    
}