using NUnit.Framework;
using Shouldly;

/*
 * Crystal Liles
 */

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class Clear
    {
        [Test]
        public void Clear_Empty()
        {

            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act

            // Assert

            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
            list.Count.ShouldBe(0);

            list.Clear();

            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
            list.Count.ShouldBe(0);
        }

        [Test, TestCaseSource("Clear_Success_Cases")]
        public void Clear_VariousItems(int[] testCase)
        {
            // Assign 

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddLast(new LinkedListNode<int>(value));
            }

            // Act

            // Assert

            list.Head.ShouldNotBeNull();
            list.Tail.ShouldNotBeNull();
            list.Count.ShouldBe(testCase.Length);

            list.Clear();

            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
            list.Count.ShouldBe(0);
        }

        static object[] Clear_Success_Cases =
                     {
                            new int[] { 0 }, 
                            new int[] { 0, 1 }, 
                            new int[] { 0, 1, 2 }, 
                            new int[] { 0, 1, 2, 3 }, 
                     };


    }
}
