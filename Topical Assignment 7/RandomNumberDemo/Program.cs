using System;
using BinaryTree;

/*
 * Crystal Liles
 */

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //int? input = null;

            // read the line from the user
            Console.WriteLine("Crystal Liles");
            Console.WriteLine("Assignment 7");
            
            var x = new Random();
            

            for (int i = 0; i < 10; i++)
            {
                int input = x.Next(0, 100);
                tree.Add(input);                
            }
            //string[] numbers = input

            //// add number to the tree
            //foreach (int input in numbers)
            //{
            //    tree.Add(input);
            //}

            // print the tree of numbers
            Console.WriteLine("{0} numbers", tree.Count);

            // and print each number using the default (in-order) enumerator
            foreach (int value in tree)
            {
                Console.Write("{0} ", value);
            

            Console.WriteLine();

            tree.Clear();
            }
        }
    }
}