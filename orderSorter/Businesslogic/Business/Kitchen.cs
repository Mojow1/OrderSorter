using System;

namespace orderSorter
{
    public class Kitchen
    {
        // KitchenTime in minutes
        
        private Boolean _veryBusyKitchen;
        private int _normalKitchenTime;
        private int _extraTimebusyKitchen;
        

        public Kitchen(bool veryBusyKitchen ,int  normalKitchenTime, int busyKitchenTime)
        {
            _veryBusyKitchen = veryBusyKitchen;
            _extraTimebusyKitchen = busyKitchenTime;
            _normalKitchenTime = normalKitchenTime;
            
        }

        public int kitchenTimeRequired()
        {
           if (_veryBusyKitchen= false)
           {
               return _normalKitchenTime;
           }
           else
           {
               return _normalKitchenTime + _extraTimebusyKitchen;
           }
        }

    }
}