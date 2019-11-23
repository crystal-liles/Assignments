using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

/*
 * Crystal Liles ~ 0.5 hrs
 */

namespace Project_2_ThreadSafe
{
    class Program
    {
        private static Dictionary<char, Action> ConsoleMenuDictionary = new Dictionary<char, Action>
        {
            {'1', () => ThreadSafeTest()}
        };

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Crystal Liles");
            Console.WriteLine("Assignment 8");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Demo the ThreadSafeTest");
                Console.WriteLine("X) Exit");
                Console.WriteLine("Select demonstration: ");

                var keyPressed = Console.ReadKey().KeyChar;
                if (keyPressed == 'x' || keyPressed == 'X') return;

                Console.WriteLine();
                Console.WriteLine();

                try
                {
                    ConsoleMenuDictionary[keyPressed].Invoke();
                }
                catch
                {

                }

                Console.WriteLine();
            }
        }

        static bool _done;

        static readonly object Locker = new object();

        static int ThreadSafeTest()
        {
            /*
             * It is important to set _done to false because if the method is ran twice
             * _done need to be reset back to false.
             */

            _done = false;

            new Thread(Go).Start();
            Go();

            return 0;
        }

        static void Go()
        {
            lock (Locker)
            {
                if (!_done)
                {
                    Console.WriteLine("Done");
                    _done = true;
                }
            }

        }
    }
}
