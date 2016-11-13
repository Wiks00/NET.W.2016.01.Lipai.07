using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public sealed class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }

        /// <summary>
        /// Create rectangle whit entered parameters
        /// </summary>
        /// <param name="x">first side of the rectangle</param>
        /// <param name="y">second side of the rectangle</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Rectangle(double x, double y)
        {
            if(x <= 0 || y <= 0)
                throw new ArgumentOutOfRangeException();
            Width = x;
            Height = y;
        }

        /// <summary>
        /// Method allows find a perimeter of the figure
        /// </summary>
        /// <returns>returns radius of the rectangle</returns>
        public double GetPerimeter() => 2 * (Width + Height);

        /// <summary>
        /// Method allows find a area of the figure
        /// </summary>
        /// <returns>returns area of the rectangle</returns>
        public double GetArea() => Width * Height;
    }
}
