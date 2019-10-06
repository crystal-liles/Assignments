using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Crystal Liles
 */

namespace CustomerManagementTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {        
        //-- Arrange
            var product = new Product()
            {
                ProductName = "Product",
                CurrentPrice = 1
            };
        bool expected = true;
    
        //--Act
        bool actual = product.Validate();

        //-- Assert
        Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductNameEmpty()
        {
            //-- Arrange
            var product = new Product()
            {
                CurrentPrice = 1
            };
            var expected = false;

            //-- Act
            bool actual = product.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);

        }
        
    }
}
