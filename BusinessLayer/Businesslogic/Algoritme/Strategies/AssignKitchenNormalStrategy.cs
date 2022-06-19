using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Interfaces;

namespace orderSorter.Businesslogic.Algoritme;

public class AssignKitchenNormalStrategy : IAssignStrategy
{
    
    private List<Timeslot> _timeSlots;
    private List<Order> _cancelledOrders;

    public AssignKitchenNormalStrategy(int intervalInMinutes, int numberOfHours, DateTime startTimeSlots, int timeSlotMax)
    {
        _timeSlots = GenerateTimeSlots(intervalInMinutes,numberOfHours, startTimeSlots, timeSlotMax);
        _cancelledOrders = new List<Order>();
    }


        
        public void AssignOrders(List<Order> orders)          // AssignOrders method/execute method; geeft een lijst met tijdslots met daaraan toegewezen orders terug
        {
            ClearOrdersAndTimeSlots();
            orders.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate)); // sorts order by date/time.
            
            for (int i = 0; i < orders.Count; i++)
            {
                Assign(orders[i]);   //  loopt alle orders door
            }
        }
        
        public void Assign(Order order)
      
        {
            for (int i = 0; i < _timeSlots.Count; i++)
            {
                if (CheckTime(order, _timeSlots[i]) && CheckMax(_timeSlots[i]))
                {
                    _timeSlots[i].TimeSlotOrders.Add(order);
                   
                   return;

                }

                if (order.AllowedEndTime.CompareTo(_timeSlots[i].Start) <=0)
                {
                    return;
                }
            }
            _cancelledOrders.Add(order);
           

        }

        
        public bool CheckTime(Order order, Timeslot timeSlot)
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
        
        
        public bool CheckMax(Timeslot timeSlot) // Checkt of de timeslot het maximum aantal orders heeft bereikt.
        {
            if (timeSlot.TimesSlotMax> timeSlot.TimeSlotOrders.Count)
            {
                return true;
            }
            return false;
        }

        
        public List<Order> GetDeniedOrders()
        {
            return _cancelledOrders;
        }

        public List<Timeslot> GetTimeSlots()
        {
            return _timeSlots;
        }

       private void ClearOrdersAndTimeSlots()
        {
            for (int i = 0; i < _timeSlots.Count; i++)
            {
                _timeSlots[i].TimeSlotOrders.Clear();
            }
            _cancelledOrders.Clear();
        }
    
    private List<Timeslot> GenerateTimeSlots(int intervalInMinutes, int numberOfHours, DateTime startTimeSlots, int timeSlotMax ) //// genereer
    {
        int numberOfTimeSlots = (60 / intervalInMinutes) * numberOfHours;
        List<Timeslot> timeSlots = new List<Timeslot>();
        DateTime start = startTimeSlots;
        DateTime end = start.AddMinutes(intervalInMinutes);

        for (int i = 1; i <= numberOfTimeSlots; i++)
        {
            timeSlots.Add(new(timeSlotMax, i, start.AddMinutes(intervalInMinutes * i), end.AddMinutes(intervalInMinutes * i).AddMilliseconds(-1)));
        
        }


        return timeSlots;
    }
}