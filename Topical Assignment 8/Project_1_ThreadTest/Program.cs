using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

/*
 * Crystal Liles ~ 2 hrs
 */

namespace Project_1_ThreadTest
{
    class Program
    {
        private static Dictionary<char, Func<int>> ConsoleMenuDictionary = new Dictionary<char, Func<int>>
        {
            {'1', () => ThreadTest()},
            {'2', () => ThreadTest2()},
            {'3', () => ThreadTest3()},
            {'4', () => ThreadTest4()},
            {'5', () => ThreadTest5()},
            {'6', () => ThreadTest6()},
            {'7', () => ThreadTest7()},
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
                Console.WriteLine("1) Demo the ThreadTest");
                Console.WriteLine("2) Demo the ThreadTest2");
                Console.WriteLine("3) Demo the ThreadTest3");
                Console.WriteLine("4) Demo the ThreadTest4");
                Console.WriteLine("5) Demo the ThreadTest5");
                Console.WriteLine("6) Demo the ThreadTest6");
                Console.WriteLine("7) Demo the ThreadTest7");
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

        private static int ThreadTest()
        {
            void WriteY()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("y");
                }
            }

            void WriteZ()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("z");
                }
            }

            void WriteW()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("w");
                }
            }

            Thread ty = new Thread(WriteY);
            ty.Start();

            Thread tz = new Thread(WriteZ);
            tz.Start();

            Thread tw = new Thread(WriteW);
            tw.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }

            return 0;

        }

        private static int ThreadTest2()
        {
            void WriteAString(string StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            Thread tz = new Thread(() => WriteAString("z"));
            tz.Start();

            Thread tw = new Thread(() => WriteAString("w"));
            tw.Start();

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            return 0;

        }

        private static int ThreadTest3()
        {
            void WriteAString(string StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            Thread tz = new Thread(() => WriteAString("z"));
            tz.Start();

            Thread tw = new Thread(() => WriteAString("z"));
            tw.Start();

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            System.Threading.Thread.Sleep(5000);

            return 0;
        }

        private static int ThreadTest4()
        {
            void WriteAString(object StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            Thread tz = new Thread(() => WriteAString("z"));
            tz.Start();

            Thread tw = new Thread(() => WriteAString("w"));
            tw.Start();

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            while (ty.IsAlive || tz.IsAlive || tw.IsAlive)
            {
                System.Threading.Thread.Sleep(10);
            }

            return 0;
        }

        private static int ThreadTest5()
        {
            void WriteAString(object StringToWrite)
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread[] aBunchOfThreads = new Thread[10];

            for (int threadNumber = 0; threadNumber < 10; threadNumber++)
            {
                aBunchOfThreads[threadNumber] = new Thread(() => WriteAString(threadNumber.ToString()));

                aBunchOfThreads[threadNumber].Start();
            }

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            while (true)
            {
                var aThreadIsStillRunning = false;
                for (var threadNumber = 0; threadNumber < 10; threadNumber++)
                {
                    aThreadIsStillRunning = aThreadIsStillRunning || aBunchOfThreads[threadNumber].IsAlive;
                }

                if (!aThreadIsStillRunning) break;

                System.Threading.Thread.Sleep(10);
            }

            return 0;
        }

        private static int ThreadTest6()
        {
            void WriteAString(object StringToWrite)
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread[] aBunchOfThreads = new Thread[10];

            for (int threadNumber = 0; threadNumber < 10; threadNumber++)
            {
                aBunchOfThreads[threadNumber] = new Thread(() => WriteAString(threadNumber.ToString()));

                aBunchOfThreads[threadNumber].Start();
            }

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            for (var threadNumber = 0; threadNumber < 10; threadNumber++)
            {
                aBunchOfThreads[threadNumber].Join();
            }

            return 0;
        }

        static bool _done;
        private static int ThreadTest7()
        {
            _done = false;
            new Thread(Go).Start();
            Go();

            static void Go()
            {
                if (!_done)
                {
                    Thread.Sleep(10);
                    _done = true;
                    Console.WriteLine("Done");
                }
            }

            return 0;
        }
    }

}
