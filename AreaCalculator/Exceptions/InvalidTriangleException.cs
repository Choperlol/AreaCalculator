using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Exceptions
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException() 
            : base("Sum of shorter sides must be more than the longest side")
        {
        }
    }
}
