using AreaCalculator.Exceptions;
using System;

namespace AreaCalculator.Core
{
    /// <summary>
    /// Implementation of <see cref="ICircle"/> interface.
    /// </summary>
    public class Circle : ICircle
    {
        /// <summary>
        /// Radius of circle.
        /// </summary>
        public double Raduis { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class that
        ///     has a raduis set.
        /// </summary>
        /// <param name="raduis">Raduis of circle.</param>
        /// <exception cref="InvalidRaduisException">Raduis lenght is not valid.</exception>
        public Circle(double raduis)
        {
            if (raduis <= 0)
            {
                throw new InvalidRaduisException(nameof(raduis));
            }

            Raduis = raduis;
        }

        /// <summary>
        /// Calculates the area of triangle.
        /// </summary>
        /// <returns>The double value of area.</returns>
        public double GetArea()
        {
            return Math.Pow(Raduis, 2) * Math.PI;
        }

    }
}
