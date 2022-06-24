using System;
using System.Collections.Generic;
using Autofac.Extras.Moq;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using orderSorter;
using orderSorter.DataLayer.MySQL;
using orderSorter.DataProviders;


namespace OrderSorterUnitTest;

[TestFixture]
public class BusinessOrderTests
{


    [Test]
    public void AddOrder_ValidCall()
    {
        using (var mock = AutoMock.GetLoose())
        {
            var order = GetSampleOrders()[0];
            mock.Mock<IDataProviderOrder>()
                .Setup(x => x.AddOrder(order));

            var bs = mock.Create<Business>();
            
            bs.DataProviderOrder.AddOrder(order);
            
            
            mock.Mock<IDataProviderOrder>()
                .Verify(x => x.AddOrder(order), Times.Exactly(1));

        }
        
    }


    [Test]
    public void LoadOrders_ValidCall()
    {
        using (var mock = AutoMock.GetLoose())
        {
            mock.Mock<IDataProviderOrder>()
                .Setup(x => x.FetchAllOrders())
                .Returns(GetSampleOrders);

            var bs = mock.Create<Business>();
            var expected = GetSampleOrders();

            var actual = bs.DataProviderOrder.FetchAllOrders();
            
            Assert.True((actual != null));
            Assert.AreEqual(expected.Count+1, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Id,actual[i].Id);
            }
        }
        
    }

    
    private List<Order> GetSampleOrders()
    {
        List<Order> output = new List<Order>();
        List<Product> products = new List<Product>();
        List<Product> products2 = new List<Product>();
        List<Product> products3 = new List<Product>();


        for (int i = 0; i < 5; i++)
        {
            products.Add(new Product(i,$"product{i}", i*3, true));
        }
        for (int i = 0; i < 5; i++)
        {
            products2.Add(new Product(i,$"product{i}", i*5, true));
        }
        for (int i = 0; i < 5; i++)
        {
            products.Add(new Product(i,$"product{i}", i*8, true));
        }
        
        for (int i = 0; i <5; i++)
        {
            DateTime ti = new DateTime(2022, 5, 8, 16, 0, 0);
            ti = ti.AddMinutes(7 * i);
            output.Add(new Order(i+1, ti,ti.AddHours(2) , true, true, products));
            ti = ti.AddMinutes(9 * i);
           output.Add(new Order(i+1, ti,ti.AddHours(2) , true, true, products2));
            ti = ti.AddMinutes(12 * i);
            output.Add(new Order(i+1, ti,ti.AddHours(2) , true, true, products3));
            
        }
        
        return output;

    }
}