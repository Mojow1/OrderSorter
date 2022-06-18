using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using orderSorter.Businesslogic.Business.Staff;

namespace OrderSorterUnitTest;

[TestFixture]
public class StaffTests
{

    private Staff _staff;
    private Deliverer _deliverer;

    [SetUp]
    public void SetUp()
    {
        List<Deliverer> deliverers = new List<Deliverer>();
        _staff = new Staff(deliverers);
        _deliverer = new Deliverer(1, "naam", true, true, false);
    }

    [Test]
    public void Adding_deliverer_Enlarges_Staff_List()
    {
        // SetUp
        // Act
        for (int i = 0; i < 10; i++)
        {
            _staff.AddDeliverer(_deliverer);
        }
        // Assert
        Assert.That(_staff.FetchAllDeliverers().Count, Is.EqualTo(10));
    }
    
    [Test]
    public void Adding_deliverer_With_Right_Id()
    {
        // SetUp
        // Act
        for (int i = 0; i < 10; i++)
        {
            _staff.AddDeliverer(_deliverer);
        }
        // Assert
        
        Assert.AreEqual(10,_staff.FetchAllDeliverers().Last().Id);
        
    }

    [Test]
    public void Calling_Deliverer_By_Id()
    {
        //Arrange
        for (int i = 0; i < 10; i++)
        {
            _staff.AddDeliverer(_deliverer);
        }
        
        //Act
       Deliverer deliverer = _staff.FetchDeliverer(5);
        
        // Assert

        Assert.That(deliverer.Id, Is.EqualTo(5));


    }
    
    
    [Test]
    public void Calling_All_Deliverers()
    {
        // SetUp
        // Act
        for (int i = 0; i < 10; i++)
        {
            _staff.AddDeliverer(_deliverer);
        }

        List<Deliverer> deliverers = _staff.FetchAllDeliverers();
        // Assert
        Assert.That(deliverers.Count, Is.EqualTo(10));
    }

    [Test]
    public void Removes_Employee_By_Making_Employed_False()
    {
        // Arrange
        for (int i = 0; i < 10; i++)
        {
            _staff.AddDeliverer(_deliverer);
        }
        
        // Act
        _staff.RemoveDeliverer(7);
        
        // Assert
        Assert.That(_staff.FetchDeliverer(7).Employed, Is.False);
        
        
    }
    
}