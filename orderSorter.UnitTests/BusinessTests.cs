using FluentAssertions;
using Moq;
using NUnit.Framework;
using orderSorter;
using orderSorter.DataLayer.MySQL;
using orderSorter.DataProviders;


namespace OrderSorterUnitTest;

[TestFixture]
public class BusinessTests
{


    [Test]
    public void Testing_Method()
    {
        Mock<IDataProviderOrder> mockOrderRepository = new Mock<IDataProviderOrder>();


        Mock<IDataProviderProduct> mockProductRepository = new Mock<IDataProviderProduct>();
        Business business = new Business(mockOrderRepository.Object,mockProductRepository.Object);
        business.Orders.Should().NotBeNull();

    }
}