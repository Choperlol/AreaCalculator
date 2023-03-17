using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Core
{
    /// <summary>
    /// Represents a triangle.
    /// </summary>
    public interface ITriangle : IGeometricFigure
    {
        /// <summary>
        /// First side of triangle.
        /// </summary>
        double SideA { get; }

        /// <summary>
        /// Second side of trianlge.
        /// </summary>
        double SideB { get; }

        /// <summary>
        /// Third side of triangle.
        /// </summary>
        double SideC { get; }

        /// <summary>
        /// Indicates if triangle is rectangular or not.
        /// </summary>
        bool IsRectangular { get; }
    }
}
