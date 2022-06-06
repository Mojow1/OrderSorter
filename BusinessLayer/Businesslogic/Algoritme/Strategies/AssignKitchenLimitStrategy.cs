using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Castle.Core.Internal;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;
using Org.BouncyCastle.Asn1.Esf;
using Org.BouncyCastle.Bcpg;

namespace orderSorter.Businesslogic.Algoritme
{
    public class AssignKitchenLimitStrategy : IAssignStrategy
    {
        private List<Timeslot> _timeSlots;
        private List<IOrder> _cancelledOrders;
        
        // constructor
        public AssignKitchenLimitStrategy(int intervalInMinutes, int numberOfHours, DateTime startTimeSlots, int timeSlotMax)
        {
            _timeSlots = GenerateTimeSlots(intervalInMinutes,numberOfHours, startTimeSlots, timeSlotMax);
            _cancelledOrders = new List<IOrder>();
        }

        
        public void AssignOrders(List<IOrder> orders)          // AssignOrders method/execute method; geeft een lijst met tijdslots met daaraan toegewezen orders terug
        {
           
            for (int i = 0; i < orders.Count; i++)
            {
                Assign(orders[i]);   // Gecheckt, hij loopt alle orders
            }
        }
        
        public void Assign(IOrder order)
      
        {
            for (int i = 0; i < _timeSlots.Count; i++)
            {
                if (CheckTime(order, _timeSlots[i]) && CheckMax(_timeSlots[i]))
                {
                    _timeSlots[i].TimeslotOrders.Add(order);
                    Console.WriteLine("order :"+ order.Id +" added to timslot: " + i);
                   return;

                }

                if (order.AllowedEndTime.CompareTo(_timeSlots[i].Start) <=0)
                {
                    return;
                }
            }
            _cancelledOrders.Add(order);
            Console.WriteLine("order :" + order.Id +" cancelled ");

        }

        
        public bool CheckTime(IOrder order, Timeslot timeSlot)
        {
            if (order.OrderDate.CompareTo(timeSlot.Start)>= 0 || timeSlot.Start.CompareTo(order.AllowedEndTime) <=0 ) 
            {
                if ( order.OrderDate.CompareTo(timeSlot.End)<0 || timeSlot.End.CompareTo(order.AllowedEndTime)>0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckTime2(IOrder order, Timeslot timeSlot)
        {
            if (timeSlot.Start.CompareTo(order.AllowedEndTime) <=0 && order.OrderDate.CompareTo(timeSlot.End)<0 )
            {
                return true;
            }

            return false;
        }
        
        public bool CheckMax(Timeslot timeSlot) // Checkt of de timeslot het maximum aantal orders heeft bereikt.
        {
            if (timeSlot.TimeslotMax > timeSlot.TimeslotOrders.Count)
            {
                return true;
            }
            return false;
        }

        
        public List<IOrder> GetCancelledOrders()
        {
            return _cancelledOrders;
        }

        public List<Timeslot> GetTimeSlots()
        {
            return _timeSlots;
        }

        public void CleanOrders()
        {
            _timeSlots.Clear();
            _cancelledOrders.Clear();
        }



        private List<Timeslot> GenerateTimeSlots(int intervalInMinutes, int numberOfHours, DateTime startTimeSlots, int timeSlotMax ) //// genereer
        {
            int numberOfTimeSlots = (60 / intervalInMinutes) * numberOfHours;
            List<Timeslot> timeSlots = new List<Timeslot>();
            DateTime time = startTimeSlots;

            for (int i = 0; i <= numberOfTimeSlots; i++)
            {
                timeSlots.Add(new(timeSlotMax, i, time, time.AddMinutes(intervalInMinutes * i)));
                time = time.AddMinutes(intervalInMinutes * i);

            }


            return timeSlots;
        }
        
        
        
        /*List<Timeslot> timeSlots = new List<Timeslot>();
        DateTime time = new DateTime(2022, 5, 8, 16, 0, 0);
            for (int i = 0; i < 8; i++)
        {
            timeSlots.Add(new Timeslot( 3,i+1 ,time, time.AddHours(1)));
            time = time.AddHours(1);
        }

    return timeSlots;*/
    }
    
    
    
    
    
}