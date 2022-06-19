using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Business
{
    public class Timeslot
    {


        public int TimesSlotMax { get;  }
        public int TimeSlotTime { get; }
        public DateTime Start { get; }
        public DateTime End { get; }
        public List<Order> TimeSlotOrders { get;  }


        public Timeslot(int timesSlotMax, int timeSlotTime, DateTime start, DateTime end, List<Order> timeSlotOrders)
        {
            TimesSlotMax = timesSlotMax;
            TimeSlotTime = timeSlotTime;
            Start = start;
            End = end;
            TimeSlotOrders = timeSlotOrders;
        }

        public Timeslot(int timesSlotMax, int timeSlotTime, DateTime start, DateTime end)
        {
            TimesSlotMax = timesSlotMax;
            TimeSlotTime = timeSlotTime;
            Start = start;
            End = end;
            TimeSlotOrders = new List<Order>();
        }
    }
}