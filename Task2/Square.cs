using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public sealed class Square : IShape
    {
        public double Side { get; }

        /// <summary>
        /// Create square whit entered parameter
        /// </summary>
        /// <param name="x">side of the square</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Square(double x)           
        {
            if (x <= 0)
                throw new ArgumentOutOfRangeException();
            Side = x;
        }

        /// <summary>
        /// Method allows find a perimeter of the figure
        /// </summary>
        /// <returns>returns perimeter of the square</returns>
        public double GetPerimeter() => Side * 4;

        /// <summary>
        /// Method allows find a area of the figure
        /// </summary>
        /// <returns>returns area of the square</returns>
        public double GetArea() => Math.Pow(Side, 2);
    }
}
