using AreaCalculator.Core;
using AreaCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Triangle_ShouldThrowInvalidSideException_WhenNegativeOrZeroSideLenght()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<InvalidSideException>(() => { IGeometricFigure figure = new Triangle(-2.543, 2, 3); });
                Assert.Throws<InvalidSideException>(() => { IGeometricFigure figure = new Triangle(0, 2, 3); });
                Assert.Throws<InvalidSideException>(() => { IGeometricFigure figure = new Triangle(3, -5.43, 6.3); });
                Assert.Throws<InvalidSideException>(() => { IGeometricFigure figure = new Triangle(3, 0, 6.3); });
                Assert.Throws<InvalidSideException>(() => { IGeometricFigure figure = new Triangle(54, 2, -10); });
                Assert.Throws<InvalidSideException>(() => { IGeometricFigure figure = new Triangle(32, 12, 0); });
            });

        }

        [Test]
        public void Triangle_ShouldThrowInvalidTriangleException_WhenSumOfLegsIsLessOrEqualsHypotenuse()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<InvalidTriangleException>(() => { IGeometricFigure figure = new Triangle(5, 2, 2); });
                Assert.Throws<InvalidTriangleException>(() => { IGeometricFigure figure = new Triangle(10, 15, 4); });
                Assert.Throws<InvalidTriangleException>(() => { IGeometricFigure figure = new Triangle(23.2, 1.234, 30.33); });
                Assert.Throws<InvalidTriangleException>(() => { IGeometricFigure figure = new Triangle(10, 10, 20); });
            });

        }

        [Test]
        public void Triangle_ShouldGetArea()
        {
            IGeometricFigure figure1 = new Triangle(2, 3, 4);
            IGeometricFigure figure2 = new Triangle(2.5, 10.5, 11.5);
            IGeometricFigure figure3 = new Triangle(30, 40, 50);

            Assert.Multiple(() =>
            {
                Assert.That(figure1.GetArea(), Is.EqualTo(Math.Sqrt(8.4375)).Within(0.000001));
                Assert.That(figure2.GetArea(), Is.EqualTo(Math.Sqrt(156.76171875)).Within(0.000001));
                Assert.That(figure3.GetArea(), Is.EqualTo(600).Within(0.000001));
            });
        }

        [Test]
        public void Triangle_ShouldCheckIfRectangular()
        {
            ITriangle figure1 = new Triangle(30, 40, 50);
            ITriangle figure2 = new Triangle(31, 43, 52);

            Assert.Multiple(() =>
            {
                Assert.That(figure1.IsRectangular, Is.EqualTo(true));
                Assert.That(figure2.IsRectangular, Is.EqualTo(false));
            });

        }
    }
}
