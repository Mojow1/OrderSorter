using System;
using System.Collections.Generic;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Business;
using orderSorter.Businesslogic.Business.Staff;
using orderSorter.Businesslogic.Fleet;
using orderSorter.Businesslogic.Interfaces;
using orderSorter.DataProviders;
using Org.BouncyCastle.Asn1.Cms;

// https://refactoring.guru/design-patterns/assignStrategy
// https://refactoring.guru/design-patterns/template-method/csharp/example

namespace orderSorter
{
    public class Business
    {
        private IDataProviderOrder _dataProviderOrder;
        private IDataProviderProduct _dataProviderProduct;
        
        private IAssignStrategy _assignStrategy;

        private List<Order> _orders;
        //private OrderAssigner _orderAssigner;
        
  
        
        // optionele order assigner ten behoeve van testen??
        public Business(  IDataProviderOrder dataProviderOrder, IDataProviderProduct dataProviderProduct)
        {
            //_orderAssigner =  new OrderAssigner();
            
            _dataProviderOrder = dataProviderOrder;
           _orders = _dataProviderOrder.FetchAllOrders();

           _dataProviderProduct = dataProviderProduct;
       
          

        }

        



      //  public OrderAssigner OrderAssigner => _orderAssigner;

        public IDataProviderOrder DataProviderOrder => _dataProviderOrder;
        
        public List<Order> Orders => _orders;
        
        
        public void SetStrategy(IAssignStrategy assignStrategy)
        {
            _assignStrategy = assignStrategy;
        }


        public void  AssignOrders(List<Order> orders)
        {
            _assignStrategy.AssignOrders(orders);
           
        }

        public IAssignStrategy AssignStrategy
        {
            get => _assignStrategy;
        }
        


        
        
    }
}