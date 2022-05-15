using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Castle.Core.Internal;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Bcpg;

namespace orderSorter.Businesslogic.Algoritme
{
    public class StrategyKitchenLimit : IStrategy
    {
        private List<Order> _orders;
        private List<Timeslot> _timeslots;
        private List<Order> _cancelledOrders;



        // constructor
        public StrategyKitchenLimit(List<Order> orders, List<Timeslot> timeslots)
        {
            _orders = orders;
            _timeslots = timeslots;
            _cancelledOrders = new List<Order>();
        }

        // Execute method
        public List<Timeslot> Execute()
        {

            //check if timeslot is full yes-add to timeslot no-check next timeslot 
            //add to timeslot 

            List<Timeslot> lijst = AssignToTimeSlot(_orders, _timeslots);
            return lijst;


        }

        public List<Timeslot> AssignToTimeSlot(List<Order> orders, List<Timeslot> _timeslots)
        {

            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine("Processing order " + i);
                if (!CheckTimeSlots(orders[i], _timeslots))
                {
                    _cancelledOrders.Add(orders[i]);
                    Console.WriteLine("order time out of working time ");

                }
                
            }






            return _timeslots;
        }


        public bool CheckTime(Order order, Timeslot timeSlot)
        {
           
            if (order.OrderDate >= timeSlot.Start && order.OrderDate < timeSlot.End)
            {
                return true;
            }

            return false;
        }

        public bool CheckMax(Timeslot timeSlot)
        {
            if (timeSlot.TimeslotMax > timeSlot.TimeslotOrders.Count)
            {
                return true;
            }

            return false;
        }

        public bool CheckTimeSlots(Order order, List<Timeslot> timeSlots)
        {
            for (int j = 0; j < timeSlots.Count; j++)
            {
                if (CheckTime(order, timeSlots[j]) && CheckMax(timeSlots[j]))
                {
                    timeSlots[j].TimeslotOrders.Add(order);
                    Console.WriteLine("addedtotimeSlot :" + j);
                    return true;
                }
               
                /*if (CheckOverTime(order, timeSlots[j]))
                {
                    for (int i=1; i < 2; i++)
                    {
                        if (j + i >= timeSlots.Count)
                        {
                            break;
                            
                        }
                        DateTime time = timeSlots[j].Start;
                        time.AddHours(i);
                        
                        if (CheckTime(order, timeSlots[j+i]) && CheckMax(timeSlots[j+i]))
                        {
                            timeSlots[j+i].TimeslotOrders.Add(order);
                            Console.WriteLine("addedtotimeSlot :" + j);
                            return true;
                        }
                    }
                }*/
                
                    
                
                


                else if (CheckTime(order, timeSlots[j]) && CheckMax(timeSlots[j]) == false)
                {
                 
                    _cancelledOrders.Add(order);
                    Console.WriteLine("timeslot if full");
                    return true;
                }
           


            }

            return false;

        }
        
        public bool CheckOverTime(Order order, Timeslot timeSlot)
        {

            
            if (timeSlot.Start.CompareTo(order.TimeDifference) < 0)
            {
                return true;
            }

            return false;
        }
    }
    
    
}