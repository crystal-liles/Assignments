using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Library
{
    public class Pentagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Pentagon(int length)
        {
            NumberOfSides = 5;
            SideLength = length;
        }

        public double GetPerimeter => NumberOfSides * SideLength;

        public double GetArea()
        {
            return 1.72 * SideLength * SideLength;
        }
    }
}
