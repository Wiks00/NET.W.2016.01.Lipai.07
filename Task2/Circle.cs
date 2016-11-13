using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public sealed class Circle:IShape
    {
        public double Radius { get; }

        /// <summary>
        /// Create circle whit entered parameter
        /// </summary>
        /// <param name="r">radius of the circle</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Circle(double r)
        {
            if(r <=0 )
                throw  new ArgumentOutOfRangeException();
            Radius = r;
        }

        /// <summary>
        /// Method allows find a perimeter of the figure
        /// </summary>
        /// <returns>returns perimeter of the circle</returns>
        public double GetPerimeter() => 2 * Radius * Math.PI;

        /// <summary>
        /// Method allows find a area of the figure
        /// </summary>
        /// <returns>returns area of the circle</returns>
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
