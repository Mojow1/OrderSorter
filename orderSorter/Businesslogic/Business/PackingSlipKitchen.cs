using System;

namespace orderSorter
{
    public class PackingSlipKitchen
    {
        private DateTime _startTimePreparing;
        private int _minutesToPrepare;
        private DateTime _endTimePreparing;

        public PackingSlipKitchen(DateTime startTimePreparing, int minutesToPrepare)
        {
            _startTimePreparing = startTimePreparing;
            _minutesToPrepare = minutesToPrepare;
            _endTimePreparing = startTimePreparing.AddMinutes(minutesToPrepare);
        }
        
        public int MinutesToPrepare => _minutesToPrepare;

        public DateTime StartTimePreparing => _startTimePreparing;

        public DateTime EndTimePreparing => _endTimePreparing;
    }
}