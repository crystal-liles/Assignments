using NUnit.Framework;
using Shouldly;

/*
 * Crystal Liles
 */

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class Remove
    {
        [Test]
        public void RemoveFirstLast_Empty_Lists()
        {
            // Assign

            // Act

            LinkedList<int> list = new LinkedList<int>();

            //Assert

            list.Count.ShouldBe(0);
            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
           
            // Act

            list.RemoveFirst();

            // Assert

            list.Count.ShouldBe(0);
            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();

            //Act

            list.RemoveLast();

            //Assert

            list.Count.ShouldBe(0);
            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
        }

        [Test]
        public void RemoveFirstLast_One_Node()
        {

            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act
            list.AddFirst(10);
            list.RemoveFirst();

            // Assert

            list.Count.ShouldBe(0);
            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();

            //Act

            list.AddFirst(10);
            list.RemoveLast();

            // Assert

            list.Count.ShouldBe(0);
            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
        }

        [Test]
        public void RemoveFirstLast_Two_Node()
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act

            list.AddFirst(10);
            list.AddFirst(20);

            list.RemoveFirst();

            // Assert

            list.Count.ShouldBe(1);
            list.Head.Value.ShouldBe(10);
            list.Tail.Value.ShouldBe(10);

            // Act

            list.AddFirst(10);
            list.RemoveLast();

            // Assert

            list.Count.ShouldBe(1);
            list.Head.Value.ShouldBe(10);
            list.Tail.Value.ShouldBe(10);
           
        }


        [Test]
        public void RemoveFirst_Ten_Nodes()
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act
            
            for (int i = 0; i < 10; i++)
            {
                list.AddFirst(i);
            }

            // Assert 

            for (int i = 10; i > 0; i--) 
            {
                list.Count.ShouldBe(i, "Unexpected list count");
                list.RemoveFirst();
            }

            // Assert

            list.Count.ShouldBe(0);
            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
        }

        [Test]
        public void RemoveLast_Ten_Nodes()
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act


            for (int i = 0; i < 10; i++)
            {
                list.AddFirst(i);
            }

            // Assert
            for (int i = 10; i > 0; i--)
            {
                list.Count.ShouldBe(i, "Unexpected list count");
                list.RemoveLast();
            }

            list.Count.ShouldBe(0);
            list.Head.ShouldBeNull();
            list.Tail.ShouldBeNull();
        }

        [Test, TestCaseSource("Remove_Missing_Cases")]
        public void Remove_Missing(int[] testData, int value)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act

            foreach (int data in testData)
            {
                list.AddLast(new LinkedListNode<int>(data));
            }

            // Assert

            list.Remove(value).ShouldBeFalse("Nothing should have been removed");
            list.Count.ShouldBe(testData.Length, "The expected list count was incorrect");
        }

        [Test, TestCaseSource("Remove_Found_Cases")]
        public void Remove_Found(int[] testData, int value)
        {
            //Assign

            LinkedList<int> list = new LinkedList<int>();

            // Act

            foreach (int data in testData)
            {
                list.AddLast(new LinkedListNode<int>(data));
            }

            // Assert

            list.Remove(value).ShouldBeTrue("A node should have been removed");
            list.Count.ShouldBe(testData.Length - 1, " The expected list count was incorrect");
        }

        static object[] Remove_Missing_Cases =
                     {
                       new object[] { new int[] { 0 }, 10 },
                       new object[] { new int[] { 0, 1 }, 10 },
                       new object[] { new int[] { 0, 1, 2 }, 10 },
                       new object[] { new int[] { 0, 1, 2, 3 }, 10 }
                     };

        static object[] Remove_Found_Cases =
                     {
                       new object[] { new int[] { 10 }, 10 },
                       new object[] { new int[] { 10, 0 }, 10 },
                       new object[] { new int[] { 0, 10 }, 10 },
                       new object[] { new int[] { 0, 0, 10 }, 10 },
                       new object[] { new int[] { 0, 10, 0 }, 10 },
                       new object[] { new int[] { 10, 0, 0}, 10 },
                     };

    }
}
