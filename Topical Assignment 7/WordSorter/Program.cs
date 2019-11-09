using System;
using BinaryTree;

/*
 * Crystal Liles
 */

namespace WordSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<string> tree = new BinaryTree<string>();

            string input = string.Empty;

            while (!input.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
            {
                // read the line from the user
                Console.Write("> ");
                input = Console.ReadLine();

                // split the line into words (on space)
                /*
                 * ProfReynolds
                 * 1. input, although OK, looks like a reserved word. I would avoid it. perhaps 'inputString' or 'source' would be better
                 * 2. my compiler is warning about a potential null string but it does not appear to be a problem.
                 */
                string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // add each word to the tree
                foreach (string word in words)
                {
                    tree.Add(word);
                }

                // print the number of words
                Console.WriteLine("{0} words", tree.Count);

                // and print each word using the default (in-order) enumerator
                foreach (string word in tree)
                {
                    Console.Write("{0} ", word);
                }

                Console.WriteLine();

                tree.Clear();
            }
        }
    }
}
