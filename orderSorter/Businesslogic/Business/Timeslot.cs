using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace orderSorter
{
    public class Timeslot
    {
        private int timeslotMax;
        private int timeslotTime;
        private DateTime start;
        private DateTime end;
        private List<Order> timeslotOrders;
        
        
        
        
        public Timeslot(int timeslotMax, int timeslotTime, DateTime start, DateTime en , List<Order> timeslotOrders)
        {
            this.TimeslotMax = timeslotMax;
            this.TimeslotTime = timeslotTime;
            this.Start = start;
            this.End = end;
            this.TimeslotOrders = timeslotOrders;
        }

        public Timeslot(int timeslotMax, int timeslotCurrent, int timeslotTime, List<Order> timeslotOrders)
        {
            this.TimeslotMax = timeslotMax;
            this.TimeslotCurrent = timeslotCurrent;
            this.TimeslotTime = timeslotTime;
            this.TimeslotOrders = timeslotOrders;
        }

        public int TimeslotMax { get; }

        public int TimeslotCurrent { get; }

        public int TimeslotTime { get; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public List<Order> TimeslotOrders { get; set; }
    }
}