using System;

namespace Model
{
    [Serializable]
    public class DbConnectionException : ApplicationException
    {
        public DbConnectionException() { }

        public DbConnectionException(string message) : base(message) { }
    }
}