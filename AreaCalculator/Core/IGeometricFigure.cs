using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Core
{
    /// <summary>
    /// Represents a geometric figure.
    /// </summary>
    public interface IGeometricFigure
    {
        /// <summary>
        /// Calculates the area of geometric figure.
        /// </summary>
        /// <returns>The double value of area.</returns>
        double GetArea();
    }
}
