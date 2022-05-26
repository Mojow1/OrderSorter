using System;
using System.Collections.Generic;

namespace orderSorter.Businesslogic.Business
{
    public class Timeslot
    {
        private int _timeslotMax;
        private int _timeslotTime;
        private DateTime _start;
        private DateTime _end;
        private List<IOrder> _timeslotOrders; 



        public Timeslot(int timeslotMax, int timeslotTime, DateTime start, DateTime end)
        {
            _timeslotMax = timeslotMax;
            _timeslotTime = timeslotTime;
            _start = start;
            _end = end;
            _timeslotOrders = new List<IOrder>();
        }


        public int TimeslotMax
        {
            get => _timeslotMax;
            set => _timeslotMax = value;
        }

        public int TimeslotTime => _timeslotTime;


        public DateTime Start
        {
            get => _start;
            set => _start = value;
        }

        public DateTime End
        {
            get => _end;
            set => _end = value;
        }

        public List<IOrder> TimeslotOrders
        {
            get => _timeslotOrders;
            set => _timeslotOrders = value;
        }
        
    }
}