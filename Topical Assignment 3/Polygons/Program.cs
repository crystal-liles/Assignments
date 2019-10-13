using Polygons.Library;
using System;

/*
 * Crystal Liles
 */

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Crystal Liles"); // use your name!
            Console.WriteLine("Assignment Week 3");
            Console.WriteLine();

            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);

            var pentagon = new Pentagon(5);
            DisplayPolygon("Pentagon", pentagon);



            Console.Write("Press any key to continue");
            Console.ReadKey();
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
                Console.WriteLine("{0} Side Length: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimeter: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown while trying to process {0}:\n   {1}",
                    polygonType, ex.GetType().Name);
                Console.WriteLine();
            }
        }
    }
}