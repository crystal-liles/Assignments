using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

/*
 * Crystal Liles
 */

namespace NodeChains
{
    class Program
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Crystal Liles");

            Debug.WriteLine("first...");
            // +-----+------+
            // |  3  | null +
            // +-----+------+
            //Node first = new Node { Value = 3 };
            var first = CreateNewNodeChainElement(3, null);
            Debug.WriteLine($"node #1: Value={first.Value} Next Node={first.Next}");

            Debug.WriteLine("middle...");
            // +-----+------+    +-----+------+
            // |  3  | null +    |  5  | null +
            // +-----+------+    +-----+------+
            //Node middle = new Node { Value = 5 };
            // +-----+------+    +-----+------+
            // |  3  |  *---+--->|  5  | null +
            // +-----+------+    +-----+------+
            //first.Next = middle;
            var middle = CreateNewNodeChainElement(5, first);
            Debug.WriteLine($"node #2: Value={middle.Value} Next Node={middle.Next}");
            Debug.WriteLine($"node #1: Value={first.Value} Next Node={first.Next} Next Node Value={first.Next.Value}");
            Debug.WriteLine("last...");

            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  | null +   |  7  | null +
            // +-----+------+    +-----+------+   +-----+------+
            //Node last = new Node { Value = 7 };
            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  |  *---+-->|  7  | null +
            // +-----+------+    +-----+------+   +-----+------+
            //middle.Next = last;
            var last = CreateNewNodeChainElement(7, middle);
            Debug.WriteLine($"node #3: Value={last.Value} Next Node={last.Next}");
            Debug.WriteLine($"node #1: Value={first.Value} Next Node={first.Next} Next Node Value={first.Next.Value}");
            Debug.WriteLine($"node #2: Value={middle.Value} Next Node={middle.Next} Next Node Value={middle.Next.Value}");


            var r = new Random();
            var workingNode = last;
            for (int anotherNode = 0; anotherNode < 5; anotherNode++)
            {
                workingNode.Next = CreateNewNodeChainElement(r.Next(100, 200), workingNode);
                workingNode = workingNode.Next;
            }

            // now iterate over each node and print the value
            PrintList(first);

            
            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        private static Node CreateNewNodeChainElement(int value, Node referenceToPreviousNode)
        {

            var newNode = new Node { Value = value };
            if (referenceToPreviousNode != null)
            {
                referenceToPreviousNode.Next = newNode;
            }
            return newNode;
        }

        private static void PrintList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
