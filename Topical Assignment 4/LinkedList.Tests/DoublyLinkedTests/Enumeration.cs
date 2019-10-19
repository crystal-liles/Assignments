using NUnit.Framework;
using Shouldly;

/*
 * Crystal Liles
 */

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class Enumeration
    {
        [Test]
        public void Enumerate_Empty()
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act

            // Assert

            list.Count.ShouldBe(0);
        }

        [Test, TestCaseSource("Enumeration_Success_Cases")]
        public void Enumerate_Various(int[] testCase)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddLast(new LinkedListNode<int>(value));
            }

            // Act

            //Assert

            // repeat enumeration multiple times
            for (int i = 0; i < 3; i++)
            {
                testCase.Length.ShouldBe(list.Count,
                                "The list length was not the expected value.");

                int expectedIndex = 0;
                foreach (int value in list)
                {
                    testCase[expectedIndex].ShouldBe(value,
                                    "The enumerated node value was not the expected value.");

                    expectedIndex++;
                }
            }
        }

        [Test, TestCaseSource("Enumeration_Success_Cases")]
        public void Enumerate_Raw_Various(int[] testCase)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddLast(new LinkedListNode<int>(value));
            }

            // Act

            // Assert

            // repeat enumeration multiple times
            for (int i = 0; i < 3; i++)
            {
                testCase.Length.ShouldBe(list.Count,
                                "The list length was not the expected value.");

                int expectedIndex = 0;

                System.Collections.Generic.IEnumerable<int> rawEnum = list;

                foreach (int value in rawEnum)
                {
                    testCase[expectedIndex].ShouldBe(value,
                                    "The enumerated value was not the expected value.");

                    expectedIndex++;
                }
            }
        }

        [Test, TestCaseSource("Enumeration_Success_Cases")]
        public void Enumerate_Backwards_Raw_Various(int[] testCase)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddLast(new LinkedListNode<int>(value));
            }
            // Act
            int expectedIndex = list.Count - 1;
            LinkedListNode<int> current = list.Tail;

            // Assert

            while (current != null)
            {
                testCase[expectedIndex].ShouldBe(current.Value, "The expected value was not found.");
                current = current.Previous;
                expectedIndex--;
            }

            expectedIndex.ShouldBe(-1, "The reverse enumeration ran the wrong number of times");

        }


        static object[] Enumeration_Success_Cases =
                     {
                            new int[] { 0 }, 
                            new int[] { 0, 1 }, 
                            new int[] { 0, 1, 2 }, 
                            new int[] { 0, 1, 2, 3 }, 
                     };

    }
}
