using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

/*
 * ProfReynolds
 */

namespace CommonFramework.Core.Tests.Extensions
{
    [TestFixture]
    public class NumericExtensionsTest
    {
        [TestCase("12", 12)]
        [TestCase("0", 0)]
        [TestCase("-1", -1)]
        [TestCase(null, 0)]
        [TestCase("test", 0)]
        [TestCase("123.45.67", 0)]
        public void ToIntTest(string testValue, int expectedResult)
        {
            // Arrange

            // Act
            int intResult = testValue.ToInt();

            // Assert
            intResult.ShouldBe(expectedResult);
        }
    }
}
