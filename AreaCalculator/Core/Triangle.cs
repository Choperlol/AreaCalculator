using AreaCalculator.Exceptions;
using System;

namespace AreaCalculator.Core
{
    /// <summary>
    /// Implementation of <see cref="ITriangle"/> interface.
    /// </summary>
    public class Triangle : ITriangle
    {
        /// <summary>
        /// Lenght of the first side of triangle.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        /// Lenght of the second side of trianlge.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        /// Lenght of the third side of triangle.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        /// Indicates if triangle is rectangular or not.
        /// </summary>
        public bool IsRectangular => IsTriangleValid(SideA, SideB, SideC) && IsRectangularTriangle(SideA, SideB, SideC);

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class that
        ///     has three sides set.
        /// </summary>
        /// <param name="sideA">Lenght of the first side of triangle.</param>
        /// <param name="sideB">Lenght of the second side of triangle.</param>
        /// <param name="sideC">Lenght of the third side of triangle.</param>
        /// <exception cref="InvalidSideException">Side lenght is not valid.</exception>
        /// <exception cref="InvalidTriangleException">Sum of shorter sides less than the longest side.</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new InvalidSideException(nameof(sideA));
            }

            if (sideB <= 0)
            {
                throw new InvalidSideException(nameof(sideB));
            }

            if (sideC <= 0)
            {
                throw new InvalidSideException(nameof(sideC));
            }

            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new InvalidTriangleException();
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates the area of triangle.
        /// </summary>
        /// <returns>The double value of area.</returns>
        public double GetArea()
        {
            return IsRectangularTriangle(SideA, SideB, SideC)
                ? CalculateRectangularTriangleArea(SideA, SideB, SideC)
                : CalculateNonRectangularTriangleArea(SideA, SideB, SideC);
        }

        private bool IsRectangularTriangle(double sideA, double sideB, double sideC)
        {
            double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);

            if (maxSide == sideA)
            {
                return sideA * sideA == sideB * sideB + sideC * sideC;
            }
            else if (maxSide == sideB)
            {
                return sideB * sideB == sideA * sideA + sideC * sideC;
            }
            else
            {
                return sideC * sideC == sideA * sideA + sideB * sideB;
            }
        }

        private double CalculateRectangularTriangleArea(double sideA, double sideB, double sideC)
        {
            double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);

            if (maxSide == sideA)
            {
                return sideB * sideC / 2;
            }
            else if (maxSide == sideB)
            {
                return sideA * sideC / 2;
            }
            else
            {
                return sideA * sideB / 2;
            }
        }

        private bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);

            if (maxSide == sideA)
            {
                return sideA < sideB + sideC;
            }
            else if (maxSide == sideB)
            {
                return sideB < sideA + sideC;
            }
            else
            {
                return sideC < sideA + sideB;
            }    
        }

        private double CalculateNonRectangularTriangleArea(double sideA, double sideB, double sideC)
        {
            double semiperimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
        }
    }
}
