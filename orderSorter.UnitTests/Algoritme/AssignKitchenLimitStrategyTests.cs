using System;
using System.Collections.Generic;
using Autofac.Extras.Moq;
using Microsoft.EntityFrameworkCore.Storage;
using NUnit.Framework;
using orderSorter;
using orderSorter.Businesslogic.Algoritme;
using orderSorter.Businesslogic.Business;

namespace OrderSorterUnitTest;

[TestFixture]
public class AssignKitchenLimitStrategyTests
{

    [Test]
    [TestCase(1)]
    [TestCase(2)]
    public void Checks_If_TimeSlot_Is_Full(int timeSlotMax )
    {
        // Arrange
        DateTime date = new DateTime(2022, 5, 8, 16, 0, 0);
        AssignKitchenLimitStrategy kitchen = new AssignKitchenLimitStrategy(40,8,date,4);
        Timeslot timeSlot = new Timeslot(1, 1, date, date.AddHours(1));
        timeSlot.TimeSlotOrders.Add(GetSampleOrders()[1]);
        timeSlot.TimeSlotOrders.Add(GetSampleOrders()[2]);
        
        //Act
        bool result = kitchen.CheckMax(timeSlot);

        // Assert
        Assert.AreEqual(false, result);
        
        

    }

    [Test]
    public void Checks_Time( )
    {
        // Arrange
        DateTime date = new DateTime(2022, 5, 8, 16, 0, 0);
        AssignKitchenLimitStrategy kitchen = new AssignKitchenLimitStrategy(40,8,date,4);


       List<Product> products = new List<Product>();
       products.Add(new Product(1, "naam", 5, true));
       Order order = new Order(1, date.AddMinutes(20),date.AddHours(2) ,true, true, products);
       Timeslot timeSlot = new Timeslot(1, 1, date, date.AddHours(1));

       // Act
       var result = kitchen.CheckTime(order, timeSlot);

       // Assert
       Assert.AreEqual(true, result);
       
    }
    
 

    [Test]
    [TestCase(40,8,4)]
    [TestCase(60,5,3)]
    [TestCase(15,5,8)]
    [TestCase(30,8,4)]
    public void Generating_TimeSlots(int intervalInMinutes, int numberOfHours, int timeslotMax )
    {
        // Arrange

        DateTime date = new DateTime(2022, 5, 8, 16, 0, 0);
        AssignKitchenLimitStrategy kitchen = new AssignKitchenLimitStrategy(intervalInMinutes,numberOfHours,date,timeslotMax);
        
        int numberOfTimeSlots = (60 / intervalInMinutes) * numberOfHours;
       
        // Act
        

        // Assert
        Assert.AreEqual(numberOfTimeSlots, kitchen.GetTimeSlots().Count);
    }
    
    
    
    
    [Test]
    [TestCase(40,8,4)]
    [TestCase(60,5,3)]
    [TestCase(15,5,8)]
    [TestCase(30,8,4)]
    public void AssignOrderTest(int intervalInMinutes, int numberOfHours, int timeslotMax)
    {
        //Arrange
        DateTime date = new DateTime(2022, 5, 8, 16, 0, 0);
        Order order = GetSampleOrders()[0];
        AssignKitchenLimitStrategy kitchen = new AssignKitchenLimitStrategy(intervalInMinutes,numberOfHours,date,timeslotMax);
       
        
        //Act
        kitchen.Assign(order);
        
        //Assert

        Assert.AreEqual(order.Id,kitchen.GetTimeSlots()[0].TimeSlotOrders[0].Id);
    }
    
    [Test]
    [TestCase(40,8,4)]
    
    public void AssignOrdersTest( int intervalInMinutes, int numberOfHours, int timeslotMax)
    {
        DateTime date = new DateTime(2022, 5, 8, 16, 0, 0);
        Order order = GetSampleOrders()[0];
        AssignKitchenLimitStrategy kitchen = new AssignKitchenLimitStrategy(intervalInMinutes,numberOfHours,date,timeslotMax);
       
        
        //Act
        
        kitchen.AssignOrders(GetSampleOrders());
        
        //Assert
        Assert.AreEqual(true,kitchen.GetDeniedOrders().Count==0);
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