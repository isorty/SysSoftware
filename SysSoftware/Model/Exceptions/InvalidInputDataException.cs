using System;

namespace Model
{
    public class InvalidInputDataException : ApplicationException
    {
        public InvalidInputDataException() { }

        public InvalidInputDataException(string message) : base(message) { }
    }
}