using BinaryTree;
using Shouldly;
using NUnit.Framework;

/*
 * Crystal Liles
 */

namespace BinaryTreeTests
{
    [TestFixture]
    public class RemoveTests
    {
        [TestCase]
        public void Remove_Head_Only_Node()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Add(4);

            //Assert.IsTrue(tree.Remove(4), "Remove should return true for found node");
            tree.Remove(4).ShouldBeTrue("Remove should return true for found node");
        }

        [TestCase]
        public void Remove_Missing_From_Tree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //         4
            //       /   \
            //      2     8 
            //     / \    /
            //    1   3  6
            //          / \
            //         5   7   

            int[] values = new[]{4, 2, 1, 3, 8, 6, 7, 5};

            foreach(int i in values)
            {
                //Assert.IsFalse(tree.Contains(10), "Tree should not contain 10");

                tree.Contains(10).ShouldBeFalse("Tree should not contain 10");

                tree.Add(i);
            }
        }
    }
}
