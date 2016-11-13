using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public sealed class Triangle : IShape
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        /// <summary>
        /// Create triangle whit entered parameters
        /// </summary>
        /// <param name="x">first side of the triangle</param>
        /// <param name="y">second side of the triangle</param>
        /// <param name="z">third  side of the triangle</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Triangle(double x, double y, double z)
        {
            if(x <= 0 || y <= 0 || z <= 0)
                throw new ArgumentOutOfRangeException();
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Method allows find a perimeter of the figure
        /// </summary>
        /// <returns>returns radius of the triangle</returns>
        public double GetPerimeter() => X + Y + Z;

        /// <summary>
        /// Method allows find a area of the figure
        /// </summary>
        /// <returns>returns area of the triangle</returns>
        public double GetArea()
        {
            var p = GetPerimeter()/2;
            return Math.Sqrt(p*(p-X)*(p-Y)*(p-Z));
        }
    }
}
