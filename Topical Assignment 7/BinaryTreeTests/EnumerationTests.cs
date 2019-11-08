using BinaryTree;
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
            tree.Contains(10).ShouldBeFalse("Tree should contain 10");

            int count = 0;
            foreach (int item in tree)
            {
                count++;
                //Assert.AreEqual(item, 10, "The item value should be 10");
                item.ShouldBe(10, "The item value should be 10");
            }
        }

    }
}
