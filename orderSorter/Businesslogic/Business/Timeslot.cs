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
        
        
        
        
        
        public Timeslot(int timeslotMax, int timeslotTime, DateTime start, DateTime end )
        {
            _timeslotMax = timeslotMax;
            _timeslotTime = timeslotTime;
            _start = start;
            _end = end;
           
     
        }

        public Timeslot(int timeslotMax, int timeslotCurrent, int timeslotTime, List<Order> timeslotOrders)
        {
            _timeslotMax = timeslotMax;
            _timeslotCurrent = timeslotCurrent;
            _timeslotTime = timeslotTime;
            _timeslotOrders = timeslotOrders;
          

        }


        public List<Order> TimeslotOrdersOverMax
        {
            get => _timeslotOrdersOverMax;
            set => _timeslotOrdersOverMax = value;
        }


        public int TimeslotMax { get; }


        public int TimeslotCurrent
        {
            get => _timeslotCurrent;
            set => _timeslotCurrent = value;
        }


        public int TimeslotTime { get; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public List<Order> TimeslotOrders { get; set; }
    }
}