using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Crystal Liles
 */

namespace CustomerManagementTests
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void OrderItemValidateValid()
        {
            //-- Arrange
            var orderitem = new OrderItem(1)
            {
                Quantity = 1,
                PurchasePrice = 1
            };
            bool expected = false;
            //-- Act
            bool actual = orderitem.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrderItemValidateMissingQuantity()
        {
            //-- Arrange
            var orderitem = new OrderItem(1)
            {
                PurchasePrice = 1
            };
            bool expected = false;

            //-- Act
            bool actual = orderitem.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrderItemValidateMissingProductID()
        {
            //-- Arrange
            var orderitem = new OrderItem()
            {
                Quantity = 1,
                PurchasePrice = 1
            };
            bool expected = false;

            //-- Act
            bool actual = orderitem.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrderItemValidateMissingPurchasePrice()
        {
            //-- Arrange
            var orderitem = new OrderItem(1)
            {
                Quantity = 1,
                PurchasePrice = null
            };
            bool expected = false;

            //-- Act
            bool actual = orderitem.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
