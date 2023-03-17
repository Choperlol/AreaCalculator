using System;

namespace AreaCalculator.Exceptions
{
    public class InvalidSideException : ArgumentException
    {
        public InvalidSideException()
            : base("Side lenght cannot be less or equal to 0")
        {
        }

        public InvalidSideException(string paramName)
            : base("Side lenght cannot be less or equal to 0", paramName)
        {
        }
    }
}
