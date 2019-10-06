using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Crystal Liles
 */

namespace CustomerManagementTests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void OrderValidateValid()
        {
            //-- Arrange
            var order = new Order();
            order.OrderDate = DateTimeOffset.Now;
            bool expected = true;

            //-- Act
            bool actual = order.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrderValidateNoOrderDate()
        {
            //-- Arrange
            var order = new Order();
            var expected = false;

            //-- Act
            bool actual = order.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
