using System.Collections.Generic;
using NUnit.Framework;
using orderSorter;
using orderSorter.Businesslogic.Interfaces;

namespace OrderSorterUnitTest;

public class StockTests
{
    [Test]
    public void Adding_Product_Enlarges_Stock_List()
    {
        // ARRAANGE
        List<IProduct> products = new List<IProduct>();
        IProduct product = new Product(1, "naam", 10, true);
        IProduct product2 = new Product(2, "naam2", 25, true);

        // ACT
        products.Add(product);
        products.Add(product2);
        
        //ASSERT
        Assert.AreEqual(2,products.Count);
    }



    [Test]
    public void Calling_Product_List()
    {
        // ARRANGE
        List<IProduct> products = new List<IProduct>();

        for (int i = 0; i < 10; i++)
        {
            products.Add(new Product(i, "naam", 10, true));
        }
        
        
        // ACT AND ASSERT
        
        Assert.AreEqual(10,products.Count);
        
        
        
    }
   
   
 
}