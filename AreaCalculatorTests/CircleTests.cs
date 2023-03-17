using AreaCalculator.Core;
using AreaCalculator.Exceptions;

namespace AreaCalculatorTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Circle_ShouldThrowInvalidRaduisException_WhenNegativeOrZeroRaduis()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<InvalidRaduisException>(() => { IGeometricFigure figure = new Circle(-2.543); });
                Assert.Throws<InvalidRaduisException>(() => { IGeometricFigure figure = new Circle(0); });
            });
        }

        [Test]
        public void Circle_ShouldGetArea()
        {
            IGeometricFigure figure1 = new Circle(2);
            IGeometricFigure figure2 = new Circle(12.345);
            IGeometricFigure figure3 = new Circle(555);
            
            Assert.Multiple(() =>
            {
                Assert.That(figure1.GetArea(), Is.EqualTo(4 * Math.PI).Within(0.0000001));
                Assert.That(figure2.GetArea(), Is.EqualTo(152.399025 * Math.PI).Within(0.0000001));
                Assert.That(figure3.GetArea(), Is.EqualTo(308025 * Math.PI).Within(0.0000001));
            });
        }
    }
}