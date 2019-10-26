using System;
using System.Collections.Generic;

/*
 * Crystal Liles
 */

namespace PostfixCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("<< your name >>");
            Console.WriteLine("Assignment 4, Project 1");
            Console.WriteLine();

            // The stack of integers not yet operated on
            var values = new Stack<int>();

            foreach (string token in args)
            {
                if (int.TryParse(token, out int value)) // if the value is an integer...
                {
                    values.Push(value); // ... push it to the stack
                }
                else
                {
                    // otherwise evaluate the expression...
                    var rightSideExpressionValue = values.Pop();
                    var leftSideExpressionValue = values.Pop();

                    switch (token) // ... and push the result back to the stack
                    {
                        case "+":
                            values.Push(leftSideExpressionValue + rightSideExpressionValue);
                            break;
                        default:
                            throw new ArgumentException($"Unrecognized token: {token}");
                    }
                }
            }

            // the last item on the stack is the result
            Console.WriteLine($"The final result is: {values.Pop()}");

            Console.WriteLine();
            Console.Write("Press a key to continue");
            Console.ReadKey();
        }
    }
}
