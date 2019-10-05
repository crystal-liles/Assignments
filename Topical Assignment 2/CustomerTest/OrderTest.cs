using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Crystal Liles
 */

namespace CustomerManagementTests
{
    class OrderTest
    {
        public void OrderValidateValid()
        {
            //-- Arrange
            var order = new Order
            {
                //OrderDate(null);
            };

            var expected = false;

            //-- Act
            var actual = order.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        public void OrderValidateNoOrderDate()
        {
            //-- Arrange

            //--Act

            //-- Assert

        }
    }
}
