using System.Collections.Generic;
using Autofac.Extras.Moq;
using Moq;
using NUnit.Framework;
using orderSorter;
using orderSorter.DataProviders;

namespace OrderSorterUnitTest;


[TestFixture]
public class BusinessProductsTests
{



    [Test]
    public void LoadProducts_ValidCall()
    {
        using (var mock = AutoMock.GetLoose())
        {
            mock.Mock<IDataProviderProduct>()
                .Setup(x => x.FetchAllProducts()
                ).Returns(GetSampleProducts);

            var bs = mock.Create<Business>();
            var expected = GetSampleProducts();

            var actual = bs.DataProviderProduct.FetchAllProducts();
            
            Assert.True(actual != null);
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].Id,actual[i].Id);
            }
            
        }
    }

    [Test]
    public void AddProduct_ValidCall()
    {
        using (var mock = AutoMock.GetLoose())
        {
            var product = GetSampleProducts()[0];
            mock.Mock<IDataProviderProduct>()
                .Setup(x => x.AddProduct(product));

            var bs = mock.Create<Business>();
            
            bs.DataProviderProduct.AddProduct(product);

           mock.Mock<IDataProviderProduct>()
               .Verify(x =>x.AddProduct(product),Times.Exactly(1));
            
           
            
        }
    }














    public List<Product> GetSampleProducts()
    {
        List<Product> products = new List<Product>();
        
        for (int i = 0; i < 15; i++)
        {
            products.Add(new Product(i,$"product{i}", i*3, true));
        }




        return products;
    }

}