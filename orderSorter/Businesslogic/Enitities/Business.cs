using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;
using Org.BouncyCastle.Asn1.Cms;

namespace orderSorter
{
    public class Business
    {
        
        private Stock _stock;
        private Fleet _fleet;
        private Staff _staff;
        private List<IOrder> _orders;

        public Business(Stock stock, Fleet fleet, Staff staff, List<IOrder> orders)
        {
            _stock = stock;
            _fleet = fleet;
           _staff = staff;
            _orders = orders;
         
        }

        public Stock Stock => _stock;

        public Fleet Fleet => _fleet;

        public Staff Staff => _staff;

        public List<IOrder> Orders => _orders;
        


        public void AssignOrdersToKitchenTimeSlots( List<IOrder> orders,int intervalInMinutes, int numberOfHours, DateTime startTimeSlots, int timeSlotMax)
        {
            OrderAssigner orderAssigner = new OrderAssigner();
            IAssignStrategy kitchen = new AssignKitchenLimitStrategy(intervalInMinutes,numberOfHours,startTimeSlots,timeSlotMax);
            
            orderAssigner.SetStrategy(kitchen);
            orderAssigner.AssignOrders(orders);
        
            
            
        }

        public List<IOrder> GetDeniedOrders(IAssignStrategy strategy)
        {
            AssignKitchenLimitStrategy kitchen = (AssignKitchenLimitStrategy) strategy;

           return kitchen.GetCancelledOrders();
        }

        public List<Timeslot> GetAssignedTimeSlots(IAssignStrategy strategy)
        {
            AssignKitchenLimitStrategy kitchen = (AssignKitchenLimitStrategy) strategy;
            
            return kitchen.GetTimeSlots();
        }
        
        
        
    }
}