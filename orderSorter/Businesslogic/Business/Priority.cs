using System;

namespace orderSorter
{
    public class Priority
    {
        private bool _priorityStatus;

        public Priority(bool priorityStatus)
        {
            _priorityStatus = priorityStatus;
        }

        // Checks priority in order

        public bool PriorityStatus => _priorityStatus;
    }
}