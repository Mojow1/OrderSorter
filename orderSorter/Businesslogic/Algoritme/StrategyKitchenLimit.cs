using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Castle.Core.Internal;
using Microsoft.VisualBasic;
using orderSorter.Businesslogic.Business;
using Org.BouncyCastle.Asn1.Esf;
using Org.BouncyCastle.Bcpg;

namespace orderSorter.Businesslogic.Algoritme
{
    public class StrategyKitchenLimit : IStrategy
    {
        private List<Timeslot> _timeSlots;
        private List<Order> _cancelledOrders;
        
        public List<Timeslot> Sort(List<Order> orders)          // Sort method/execute method; geeft een lijst met tijdslots met daaraan toegewezen orders terug
        {
            

            for (int i = 0; i < orders.Count; i++)
            {

                Assign(orders[i]);   // Gecheckt, hij loopt alle orders
            }
            return _timeSlots;
        }
        
        public void Assign(Order order)
        {
            List<Order> cancelled = new List<Order>();
            for (int i = 0; i < _timeSlots.Count; i++)
            {
                if (CheckTime2(order, _timeSlots[i]) && CheckMax(_timeSlots[i]))
                {
                    _timeSlots[i].TimeslotOrders.Add(order);
                    Console.WriteLine("order :"+ order.Id +" added to timslot: " + i);
                   return;

                }
            }
            cancelled.Add(order);
            //_cancelledOrders.Add(order);

            _cancelledOrders = cancelled;
            Console.WriteLine("order :" + order.Id +" cancelled ");

        }

        
        public bool CheckTime(Order order, Timeslot timeSlot)
        {
            if (order.OrderDate.CompareTo(timeSlot.Start)>= 0 || timeSlot.Start.CompareTo(order.TimeDifference) <=0 ) 
            {
                if ( order.OrderDate.CompareTo(timeSlot.End)<0 || timeSlot.End.CompareTo(order.TimeDifference)>0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckTime2(Order order, Timeslot timeSlot)
        {
            if (timeSlot.Start.CompareTo(order.TimeDifference) <=0 && order.OrderDate.CompareTo(timeSlot.End)<0 )
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
        
        // constructor
        public StrategyKitchenLimit( List<Timeslot> timeslots)
        {
            
            _timeSlots = timeslots;
            _cancelledOrders = new List<Order>();
        }
        
        
        
        

        
        
        
        

    }
    
    
    
    
    
}