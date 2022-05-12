using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace orderSorter
{
    public class Timeslot
    {
        private int _timeslotMax;
        private int _timeslotTime;
        private int _timeslotCurrent;
        private DateTime _start;
        private DateTime _end;
        private List<Order> _timeslotOrders; 
        private List<Order> _timeslotOrdersOverMax;


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
            set => _timeslotMax = value;
        }

        public int TimeslotTime
        {
            get => _timeslotTime;
            set => _timeslotTime = value;
        }

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

        public List<Order> TimeslotOrders
        {
            get => _timeslotOrders;
            set => _timeslotOrders = value;
        }

        public List<Order> TimeslotOrdersOverMax
        {
            get => _timeslotOrdersOverMax;
            set => _timeslotOrdersOverMax = value;
        }
    }
}