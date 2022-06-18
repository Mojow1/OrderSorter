using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using orderSorter;
using orderSorter.Businesslogic.Interfaces;

namespace OrderSorterUnitTest;

    [TestFixture]
    public class StockTests
    {
       
        private Stock _stock;
        private Product _product;

    // SetUp
    [SetUp]
    public void SetUp()
    {
        List<Product> products = new List<Product>();
        _stock = new Stock(products);
        _product = new Product("naam", 10, true);
    }
    
    
    [Test]
    public void Adding_Product_Enlarges_Stock_List()
    {
        
        //SetUp
        // ACT
        for (int i = 0; i < 10; i++)
        {
            _stock.AddProduct(_product);
        }
        
        //ASSERT
        Assert.AreEqual(10,_stock.FetchAllProducts().Count);
    }

    
    [Test]
    public void Adding_Product_With_Right_Id()
    {
        //SetUp
        
        // ACT
        for (int i = 0; i < 10; i++)
        {
            _stock.AddProduct(_product);
        }
        
        // ASSERT

        Assert.AreEqual(10, _stock.FetchAllProducts().Last().Id);

    }



    [Test]
    public void Calling_All_Products()
    {
        //SetUp
        
        // ACT
        for (int i = 0; i < 10; i++)
        {
            _stock.AddProduct(_product);
        }
        
        // ASSERT
        
      
        Assert.That(_stock.FetchAllProducts().Count, Is.EqualTo(10));
    

    }

    [Test]
    public void Removes_Product_By_Making_InStock_False()
    {
        //SetUp
        
        // ACT
        for (int i = 0; i < 10; i++)
        {
            _stock.AddProduct(_product);
        }
        
        _stock.RemoveProduct(10);
        
        // ASSERT
        Assert.AreEqual(false,_stock.FetchProduct(10).InStock);
    }
 
}