using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace orderSorter
{
    public class Timeslot
    {
        private int timeslotMax;
        private int timeslotCurrent;
        private int timeslotTime;
        private List<Order> timeslotOrders;
        private DateTime start;
        private DateTime end;
        private List<PackingSlipKitchen> _packingSlipKitchens;

        public Timeslot(int timeslotMax, int timeslotCurrent, int timeslotTime, List<Order> timeslotOrders)
        {
            this.timeslotMax = timeslotMax;
            this.timeslotCurrent = timeslotCurrent;
            this.timeslotTime = timeslotTime;
            this.timeslotOrders = timeslotOrders;
        }

        public int TimeslotMax => timeslotMax;

        public int TimeslotCurrent => timeslotCurrent;

        public int TimeslotTime => timeslotTime;

        public DateTime Start
        {
            get => start;
            set => start = value;
        }

        public DateTime End
        {
            get => end;
            set => end = value;
        }

        public List<Order> TimeslotOrders
        {
            get => timeslotOrders;
            set => timeslotOrders = value;
        }
    }
}