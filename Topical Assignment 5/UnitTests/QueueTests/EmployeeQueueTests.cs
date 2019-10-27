using System;
using System.Collections;
using NUnit.Framework;
using Shouldly;

/*
 * Crystal Liles
 */
namespace UnitTests.QueueTests
{
    public class EmployeeQueueTests
    {
        [SetUp]
        public void Setup()
        {
        }

        // normally, this would be at the bottom of the unit test
        // notice, this static array is utilized by the various individual tests
        private static readonly string[][] QueueTestData = new[]
        {
            new string[] {
                "Fred Flintstone",
                "Wilma Flintstone",
                "Barney Rubble",
                "Fred Mertz",
                "Ethel Mertz",
                "Fred Astair",
                "Ginger Rogers",
                "Fred Savage",
                "Winnie Cooper"
                }
        };

        [Test]
        [TestCaseSource("QueueTestData")]
        public void Queue_Success_Cases(string[] testData) // note: this is from where the test data arrives
        {
            var queue = new Queue(); // this is the non-generic class. Note the usings!

            // here we test the Enqueue operations
            for (var i = 0; i < testData.Length; i++) // add an element and validate
            {
                queue.Count.ShouldBe(i, "The queue count is off");

                queue.Enqueue(testData[i]);

                queue.Count.ShouldBe(i + 1, "The queue count is off");

                queue.Peek().ShouldBe(testData[0], "The first Enqueued value is not peeking");

            }

            queue.Count.ShouldBe(testData.Length, "The end count was not as expected");

            // here we test the queue enumeration
            var counter = 0; // this helps keep synchronized to the test cases
            foreach (string value in queue)
            {
                value.ShouldBe(testData[counter], "The enumeration is not accurate");
                counter++;
            }

            // here we peek and Dequeue through the queue
            // note the for loop starts at the end and works backwards
            counter = queue.Count;
            for (var item = 0; item < testData.Length; item++)
            {
                var expected = testData[item];
                queue.Peek().ShouldBe(expected, "The peeked value was not expected");
                queue.Dequeue().ShouldBe(expected, "The Dequeued value was not expected");
                counter--;
                queue.Count.ShouldBe(counter, "The Dequeued value was not expected");
            }
        }

        [Test]
        public void Dequeue_From_Empty_Throws()
        {
            var queue = new Queue();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Dequeue();
            }
            );
        }

        [Test]
        public void Dequeue_From_Empty_Throws_After_Enqueue()
        {
            var queue = new Queue();

            queue.Enqueue(1);
            queue.Dequeue();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Dequeue();
            }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws()
        {
            var queue = new Queue();
            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Peek();
            }
            );
        }

        [Test]
        public void Peek_From_Empty_Throws_After_Enqueue()
        {
            var queue = new Queue();

            queue.Enqueue(1);
            queue.Dequeue();

            Should.Throw<InvalidOperationException>(() =>
            {
                var dequeuedValue = queue.Peek();
            }
            );
        }
    }
}
