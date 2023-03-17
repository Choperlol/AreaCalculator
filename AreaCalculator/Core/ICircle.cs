using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Core
{
    /// <summary>
    /// Represents a circle.
    /// </summary>
    public interface ICircle : IGeometricFigure
    {
        /// <summary>
        /// Raduis of circle.
        /// </summary>
        double Raduis { get; }
    }
}
