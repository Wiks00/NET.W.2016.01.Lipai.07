using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        private static readonly object[] sourceListsForPerimeter =
        {
            new object[] {new Circle(3), 19},
            new object[] {new Rectangle(3,7), 20},
            new object[] {new Triangle(2,3,4), 9},
            new object[] {new Square(4), 16}
        };

        private static readonly object[] sourceListsForArea =
        {
            new object[] {new Circle(3), 28},
            new object[] {new Rectangle(3,7), 21},
            new object[] {new Triangle(2,3,4), 3},
            new object[] {new Square(4), 16}
        };
        
        [Test,TestCaseSource(nameof(sourceListsForPerimeter))]
        public void Shape_GetPerimeterOfTheFigure(IShape figure, double expectedResult) 
            => Assert.AreEqual(Math.Round(figure.GetPerimeter()), expectedResult);

        [Test, TestCaseSource(nameof(sourceListsForArea))]
        public void Shape_GetAreafTheFigure(IShape figure, double expectedResult)
            => Assert.AreEqual(Math.Round(figure.GetArea()), expectedResult);
    }
}
