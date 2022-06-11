using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DataProviders;
using Org.BouncyCastle.Asn1.Cms;

namespace orderSorter
{
    public class Business
    {
        
        private Stock _stock;
        private Fleet _fleet;
        private Staff _staff;
        private List<IOrder> _orders;
        private OrderAssigner _orderAssigner;
        private IDataProviderOrder _dataProviderOrder;
        public Business( IDataProviderOrder dataProviderOrder)
        {
           
           _dataProviderOrder = dataProviderOrder;
           //_orders = _dataProviderOrder.FetchAllOrders();
            _orderAssigner = new OrderAssigner();

        }

        public Stock Stock => _stock;

        public OrderAssigner OrderAssigner => _orderAssigner;

        public IDataProviderOrder DataProviderOrder => _dataProviderOrder;

        public Fleet Fleet => _fleet;

        public Staff Staff => _staff;

        public List<IOrder> Orders => _orders;
        


        
        
    }
}