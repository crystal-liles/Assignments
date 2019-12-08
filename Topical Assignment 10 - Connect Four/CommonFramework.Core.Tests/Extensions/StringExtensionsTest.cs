using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonFramework.Core;
using NUnit;
using NUnit.Framework;
using Shouldly;

/*
 * ProfReynolds
 */

namespace CommonFramework.Core.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [TestCase(null, true)]
        [TestCase("", true)]
        [TestCase("     ", true)]
        [TestCase("Mark Reynolds", false)]
        [TestCase("  spaces before and after  ", false)]
        public void IsNullOrWhiteSpaceTest(string testValue, bool expectedResult)
        {
            // Arrange

            // Act
            var wasNullOrWhiteSpace = testValue.IsNullOrWhiteSpace();

            // Assert
            wasNullOrWhiteSpace.ShouldBe(expectedResult);
        }
    }
}
