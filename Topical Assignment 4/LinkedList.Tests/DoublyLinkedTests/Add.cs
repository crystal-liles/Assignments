using System.Linq;
using NUnit.Framework;
using Shouldly;

/*
 * Crystal Liles
 */

namespace DoublyLinkedList.Tests
{
    [TestFixture]
    public class Add
    {
        [Test, TestCaseSource("Add_Success_Cases")]
        public void Add_Raw_Value_Success_Cases(int[] testCase)
        {   // Assign

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.Add(value);
            }

            // Act 

            //Assert

            testCase.Length.ShouldBe(list.Count,
                "There was an unexpected number of list items");

            testCase.Last().ShouldBe(list.Head.Value, 
                "The first item value was incorrect");
            
            testCase.First().ShouldBe(list.Tail.Value, 
                "The last item value was incorrect");

            //Act

            int[] reversed = testCase.Reverse().ToArray();

            // Assert 

            int current = 0;

            foreach (int value in list)
            {
                reversed[current].ShouldBe( value, $"The list value at index {current} was incorrect.");
                current++;
            }
        }

        [Test, TestCaseSource("Add_Success_Cases")]
        public void AddFirst_Node_Value_Success_Cases(int[] testCase)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddFirst(new LinkedListNode<int>(value));
            }

            // Act

            // Assert

            testCase.Length.ShouldBe(list.Count,
                "There was an unexpected number of list items");

            testCase.Last().ShouldBe(list.Head.Value,
                "The first item value was incorrect");

            testCase.First().ShouldBe(list.Tail.Value,
                "The last item value was incorrect");

            // Act 

            int[] reversed = testCase.Reverse().ToArray();

            // Assert 

            int current = 0;

            foreach (int value in list)
            {
                reversed[current].ShouldBe(value, $"The list value at index {current} was incorrect.");
                current++;
            }
        }

        [Test, TestCaseSource("Add_Success_Cases")]
        public void AddLast_Raw_Value_Success_Cases(int[] testCase)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddLast(value);
            }

            // Act

            testCase.Length.ShouldBe(list.Count,
                "There was an unexpected number of list items");

            testCase.First().ShouldBe(list.Head.Value,
                "The first item value was incorrect");

            testCase.Last().ShouldBe(list.Tail.Value,
                "The last item value was incorrect");

            //Assert

            int current = 0;
            foreach (int value in list)
            {
                testCase[current].ShouldBe(value, $"The list value at index {current} was incorrect.");
                current++;
            }
        }

        [Test, TestCaseSource("Add_Success_Cases")]
        public void AddLast_Node_Value_Success_Cases(int[] testCase)
        {
            // Assign

            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddLast(new LinkedListNode<int>(value));
            }

            // Act

            testCase.Length.ShouldBe(list.Count,
                "There was an unexpected number of list items");

            testCase.First().ShouldBe(list.Head.Value,
                "The first item value was incorrect");

            testCase.Last().ShouldBe(list.Tail.Value,
                "The last item value was incorrect");

            // Assert

            int current = 0;
            foreach (int value in list)
            {
                testCase[current].ShouldBe(value, $"The list value at index {current} was incorrect.");
                current++;
            }
        }


        static object[] Add_Success_Cases =
                     {
                            new int[] { 0 }, 
                            new int[] { 0, 1 }, 
                            new int[] { 0, 1, 2 }, 
                            new int[] { 0, 1, 2, 3 }, 
                     };
    }
}
