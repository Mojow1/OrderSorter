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
        List<Product> products = new List<Product>();
        Product product = new Product(1, "naam", 10, true);
        Product product2 = new Product(2, "naam2", 25, true);

        // ACT
        products.Add(product);
        products.Add(product2);
        
        //ASSERT
        Assert.AreEqual(2,products.Count);
    }

    [Test]
    public void Adding_Product_With_Right_Id()
    {
        // ARRANGE
        List<Product> products = new List<Product>();
        Product product = new Product(1, "naam", 10, true);
        Product product2 = new Product(2, "naam2", 25, true);
        products.Add(product);
        products.Add(product2);
        // ACT
        
        int id = products.Count + 1;
        product.Id = id;
        
        Product product3 = new Product(id, "naam3", 25, true);
        products.Add(product3);
        
        // ASSERT
        
        Assert.AreEqual(3,products.Find(x => x.Name == "naam3").Id);
        
    }



    [Test]
    public void Calling_Product_List()
    {
        // ARRANGE
        List<Product> products = new List<Product>();

        for (int i = 0; i < 10; i++)
        {
            products.Add(new Product(i, "naam", 10, true));
        }
        
        
        // ACT AND ASSERT
        
        Assert.AreEqual(10,products.Count);
        
    }
   
   
 
}