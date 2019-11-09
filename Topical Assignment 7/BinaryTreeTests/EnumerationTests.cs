using System.Diagnostics;
using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using NUnit.Framework;


/*
 * Crystal Liles
 */

namespace BinaryTreeTests
{
    [TestFixture]
    public class EnumerationTests
    {
        [TestCase]
        public void Enumerator_Of_Single()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //Assert.IsFalse(tree.Contains(10), "Tree should not contain 10 yet");
            tree.Contains(10).ShouldBeFalse("Tree should not contain 10 yet");


            tree.Add(10);

            //Assert.IsTrue(tree.Contains(10), "Tree should contain 10");
            tree.Contains(10).ShouldBeTrue("Tree should contain 10");

            int count = 0;
            foreach (int item in tree)
            {
                count++;
                //Assert.AreEqual(item, 10, "The item value should be 10");
                item.ShouldBe(10, "The item value should be 10");
            }
        }
  
        [TestCase]
        public void Item_Count()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            int[] values = new[] { 4, 2, 1, 3, 8, 6, 7, 5 };

            foreach (int i in values)
            {
                tree.Add(i);
            }

            tree.Count.ShouldBe(8, "The item count is 8.");

            /*
             * ProfReynolds
             * consider this!
             */
            int[] expectedResult = {1, 2, 3, 4, 5, 6, 7, 8};
            var loopCounter = 0;
            foreach (var element in tree)
            {
                element.ShouldBe(expectedResult[loopCounter++]); // notice I increment loopCounter after I use it
            }
        }

    }
}
