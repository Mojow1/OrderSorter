using System;

namespace orderSorter
{
    public class DeliveryPriority
    {
        private Boolean _priorityHigh;

        public DeliveryPriority(bool priorityHigh)
        {
            _priorityHigh = priorityHigh;
        }

        // Checks priority in order
        public Boolean CheckPriority()
        {
            return _priorityHigh;
        }
        
    }
}