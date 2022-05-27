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
        private List<IOrder> _cancelledOrders;
        
        // constructor
        public StrategyKitchenLimit( List<Timeslot> timeslots)
        {
            
            _timeSlots = timeslots;
            _cancelledOrders = new List<IOrder>();
        }

        
        public List<Timeslot> Execute(List<IOrder> orders)          // Execute method/execute method; geeft een lijst met tijdslots met daaraan toegewezen orders terug
        {
            

            for (int i = 0; i < orders.Count; i++)
            {

                Execute(orders[i]);   // Gecheckt, hij loopt alle orders
            }
            return _timeSlots;
        }
        
        public void Execute(IOrder order)
        {
            List<IOrder> cancelled = new List<IOrder>();
            for (int i = 0; i < _timeSlots.Count; i++)
            {
                if (CheckTime2(order, _timeSlots[i]) && CheckMax(_timeSlots[i]))
                {
                    _timeSlots[i].TimeslotOrders.Add(order);
                    Console.WriteLine("order :"+ order.Id +" added to timslot: " + i);
                   return;

                }
            }
            //cancelled.Add(order);
            //_cancelledOrders.Add(order);

            //_cancelledOrders = cancelled;
            
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

        public void CleanOrders()
        {
            _timeSlots.Clear();
            _cancelledOrders.Clear();
        }
    }
    
    
    
    
    
}