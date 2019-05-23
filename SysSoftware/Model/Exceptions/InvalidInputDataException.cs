using System;

namespace Model
{
    [Serializable]
    public class InvalidInputDataException : ApplicationException
    {
        public InvalidInputDataException() { }

        public InvalidInputDataException(string message) : base(message) { }
    }
}