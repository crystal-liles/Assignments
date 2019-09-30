using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                FirstName = "Crystal",
                LastName = "Liles"
            };
            var expected = "Liles, Crystal";

            //--Act
            var actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            var customer = new Customer
            {
              LastName = "Liles"
            };
            var expected = "Liles";

            //--Act
            var actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            var customer = new Customer
            {
                FirstName = "Crystal"
            };
            var expected = "Crystal";

            //--Act
            var actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var C1 = new Customer();
            C1.FirstName = "Crystal";
            Customer.InstanceCount += 1;

            var C2 = new Customer();
            C2.FirstName = "Erin";
            Customer.InstanceCount += 1;

            var C3 = new Customer();
            C3.FirstName = "Aaron";
            Customer.InstanceCount += 1;

            //--Act


            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
