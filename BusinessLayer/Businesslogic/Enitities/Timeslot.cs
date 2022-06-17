using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Business
{
    public class Timeslot
    {
        private int _timeslotMax;
        private int _timeslotTime;
        private DateTime _start;
        private DateTime _end;
        private List<Order> _timeslotOrders; 



        public Timeslot(int timeslotMax, int timeslotTime, DateTime start, DateTime end)
        {
            _timeslotMax = timeslotMax;
            _timeslotTime = timeslotTime;
            _start = start;
            _end = end;
            _timeslotOrders = new List<Order>();
        }


        public int TimeslotMax
        {
            get => _timeslotMax;
        }

        public int TimeslotTime => _timeslotTime;


        public DateTime Start
        {
            get => _start;
        }

        public DateTime End
        {
            get => _end;
        }

        public List<Order> TimeslotOrders
        {
            get => _timeslotOrders;
            set => _timeslotOrders = value;
        }
        
    }
}