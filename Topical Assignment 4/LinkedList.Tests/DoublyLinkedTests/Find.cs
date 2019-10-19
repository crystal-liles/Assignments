using NUnit.Framework;
using Shouldly;

/*
 * Crystal Liles
 */

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class Find
    {
        [Test]
        public void Find_Empty()
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act

            // Assert

            list.Contains(10).ShouldBeFalse("Nothing should have been found.");
        }

        [Test, TestCaseSource("Find_Missing_Cases")]
        public void Find_Missing(int[] testData, int value)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act 

            foreach (int data in testData)
            {
                list.AddLast(new LinkedListNode<int>(data));
            }

            // Assert

            list.Contains(value).ShouldBeFalse("Nothing should have been found.");
        }

        [Test, TestCaseSource("Find_Found_Cases")]
        public void Find_Found(int[] testData, int value)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act

            foreach (int data in testData)
            {
                list.AddLast(new LinkedListNode<int>(data));
            }

            // Assert

            list.Contains(value).ShouldBeTrue("There should have been a node found");
        }

        static object[] Find_Missing_Cases =
                     {
                       new object[] { new int[] { 0 }, 10 },
                       new object[] { new int[] { 0, 1 }, 10 },
                       new object[] { new int[] { 0, 1, 2 }, 10 },
                       new object[] { new int[] { 0, 1, 2, 3 }, 10 }
                     };

        static object[] Find_Found_Cases =
                     {
                       new object[] { new int[] { 10 }, 10 },
                       new object[] { new int[] { 10, 0 }, 10 },
                       new object[] { new int[] { 0, 10 }, 10 },
                       new object[] { new int[] { 0, 1, 10 }, 10 },
                       new object[] { new int[] { 0, 10, 0 }, 10 },
                     };

    }
}
