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

        [TestCase]
        public void IsNullOrWhiteSpace_IsNull()
        {
            // Arrange
            string testCondition = null;

            //Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            //Assert
            actualResult.ShouldBeTrue();
        }

        [TestCase]
        public void IsNullOrWhiteSpace_IsEmpty()
        {
            // Arrange
            string testCondition = "";

            //Act
            var actualResult = testCondition.IsNullOrEmpty();

            //Assert
            actualResult.ShouldBeTrue();
        }

        [TestCase]
        public void IsNullOrWhiteSpace_IsSpaces()
        {
            // Arrange
            string testCondition = "";

            //Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            //Assert
            actualResult.ShouldBeTrue();
        }

        [TestCase]
        public void IsNullOrWhiteSpace_HasContent()
        {
            // Arrange
            string testCondition = "Hello";

            //Act
            var actualResult = testCondition.IsNullOrWhiteSpace();

            //Assert
            actualResult.ShouldBeFalse();
        }

        #endregion

        #region Left

        [TestCase]
        public void Left_Normal()
        {
            //Arrange
            string testCondition = "Crystal Liles";
            int numCharacters = 8;

            //Act 
            var actualResult = testCondition.Left(numCharacters);

            //Assert
            actualResult.ShouldBe(expected: "Crystal ");
        }

        [TestCase]
        public void Left_IsNull()
        {
            //Arrange
            string testCondition = null;
            int numCharacters = 3;

            //Act 
            var actualResult = testCondition.Left(numCharacters);

            //Assert
            actualResult.ShouldBeNull();
        }

        [TestCase]
        public void Left_NoCharacters()
        {
            //Arrange
            string testCondition = "";
            int numCharacters = 3;

            //Act 
            var actualResult = testCondition.Left(numCharacters);

            //Assert
            actualResult.ShouldBeEmpty();
        }

        [TestCase]
        public void Left_TooManyCharacters()
        {
            //Arrange
            string testCondition = "Crystal Liles";
            int numCharacters = 20;

            //Act 
            var actualResult = testCondition.Left(numCharacters);

            //Assert
            actualResult.ShouldBe(expected: "Crystal Liles");

        }
        #endregion

        #region Right

        [TestCase]
        public void Right_Normal()
        {
            //Arrange
            string testCondition = "Crystal Liles";
            int numCharacters = 8;

            //Act 
            var actualResult = testCondition.Right(numCharacters);

            //Assert
            actualResult.ShouldBe(expected: "al Liles");
        }

        [TestCase]
        public void Right_IsNull()
        {
            //Arrange
            string testCondition = null;
            int numCharacters = 3;

            //Act 
            var actualResult = testCondition.Right(numCharacters);

            //Assert
            actualResult.ShouldBeNull();
        }

        [TestCase]
        public void Right_NoCharacters()
        {

            //Arrange
            string testCondition = "";
            int numCharacters = 3;

            //Act 
            var actualResult = testCondition.Right(numCharacters);

            //Assert
            actualResult.ShouldBeEmpty();
        }

        [TestCase]
        public void Right_TooManyCharacters()
        {
            //Arrange
            string testCondition = "Crystal Liles";
            int numCharacters = 20;

            //Act 
            var actualResult = testCondition.Right(numCharacters);

            //Assert
            actualResult.ShouldBe(expected: "Crystal Liles");

        }
        #endregion

    }
}
