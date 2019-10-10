using CommonFramework.Core;
using Shouldly;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

/*
 *Crystal Liles
 */

namespace CommonFramework.Core.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        #region IsNullOrEmpty

        [TestCase]
            public void IsNullOrEmpty_IsNull()
            {
                // Arrange
                string testCondition = null;

                //Act
                var actualResult = testCondition.IsNullOrEmpty();

                //Assert
                actualResult.ShouldBeTrue();
            }

        [TestCase]
            public void IsNullOrEmpty_IsEmpty()
            {
                // Arrange
                string testCondition = "";

                //Act
                var actualResult = testCondition.IsNullOrEmpty();

                //Assert
                actualResult.ShouldBeTrue();
            }

        [TestCase]
            public void IsNullOrEmpty_IsSpaces()
            {
            // Arrange
            string testCondition = "";

                //Act
                var actualResult = testCondition.IsNullOrEmpty();

                //Assert
                actualResult.ShouldBeTrue();
            }

        [TestCase]
            public void IsNullOrEmpty_HasContent()
            {
                // Arrange
                string testCondition = "Hello";

                //Act
                var actualResult = testCondition.IsNullOrEmpty();

                //Assert
                actualResult.ShouldBeFalse();
            }

            #endregion

            #region IsNullOrWhiteSpace

            #endregion

            #region Left

            #endregion

            #region Right

            #endregion
        

    }
}
