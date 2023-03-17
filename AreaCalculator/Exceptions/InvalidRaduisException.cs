using System;

namespace AreaCalculator.Exceptions
{
    public class InvalidRaduisException : ArgumentException
    {
        public InvalidRaduisException()
            : base("Raduis lenght cannot be less or equal to 0")
        {
        }

        public InvalidRaduisException(string paramName)
           : base("Raduis lenght cannot be less or equal to 0", paramName)
        {
        }
    }
}
