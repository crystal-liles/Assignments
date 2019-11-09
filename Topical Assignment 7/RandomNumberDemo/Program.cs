using System;
using BinaryTree;

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(int[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //int? input = null;

            // read the line from the user
            Console.Write("Crystal Liles");
            Console.Write("Assignment 7");

            for (int i = 0; i < 9; i++)
            {
                    int input = new Random.Next(0, 100);
                    
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
            foreach (int input in tree)
            {
                Console.Write("{0} ", input);
            }

            Console.WriteLine();

            tree.Clear();
            }
        }
    }
}