using System;
using System.Collections;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Shouldly;

/*
 * Crystal Liles
 * demonstrator of basic Stack operations
 */
namespace UnitTests.StackTests
{
    public class NetBasicQueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // normally, this would be at the bottom of the unit test
        // notice, this static array is utilized by the various individual tests
        private static readonly int[][] StackTestData = new[]
        {
            new int[0],
            new [] { 0 },
            new [] { 0, 1 },
            new [] { 0, 1, 2 },
            new [] { 0, 1, 2, 3 },
            new [] { 0, 1, 2, 3, 4 },
            new [] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
        };

        [Test]
        [TestCaseSource("StackTestData")]
        public void Stack_Success_Cases(int[] testData) // note: this is from where the test data arrives
        {
            var stack = new Stack(); // this is the non-generic class. Note the usings!

            // here we test the push operations
            for (var i = 0; i < testData.Length; i++) // add an element and validate
            {
                stack.Count.ShouldBe(i, "The stack count is off");

                stack.Push(testData[i]);

                stack.Count.ShouldBe(i + 1, "The stack count is off");

                stack.Peek().ShouldBe(testData[i], "The recently pushed value is not peeking");
            }

            stack.Count.ShouldBe(testData.Length, "The end count was not as expected");

            // here we test the stack enumeration
            var counter = stack.Count; // this helps keep synchronized to the test cases
            foreach (int value in stack)
            {
                counter--;
                value.ShouldBe(testData[counter], "The enumeration is not accurate");
            }

            // here we peek and pop through the stack
            // note the for loop starts at the end and works backwards
            for (var item = testData.Length - 1; item >= 0; item--)
            {
                var expected = testData[item];
                stack.Peek().ShouldBe(expected, "The peeked value was not expected");
                stack.Pop().ShouldBe(expected, "The popped value was not expected");
                stack.Count.ShouldBe(item, "The popped value was not expected");
            }
        }

        [Test]
        public void Pop_From_Empty_Throws()
        {
            var stack = new Stack();

            Should.Throw<InvalidOperationException>(() =>
                {
                    var poppedValue = stack.Pop();
                }
            );
        }

        [Test]
        public void Pop_From_Empty_Throws_After_Push()
        {
            var stack = new Stack();
            
            stack.Push(1);
            stack.Pop();

            Should.Throw<InvalidOperationException>(() =>
                {
                    var poppedValue = stack.Pop();
                }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws()
        {
            var stack = new Stack();
            Should.Throw<InvalidOperationException>(() =>
                {
                    var poppedValue = stack.Peek();
                }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws_After_Push()
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Pop();

            Should.Throw<InvalidOperationException>(() =>
                {
                    var poppedValue = stack.Peek();
                }
            );
        }
    }
}
