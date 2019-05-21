using System;

namespace Model
{
    public class DbConnectionException : ApplicationException
    {
        public DbConnectionException() { }

        public DbConnectionException(string message) : base(message) { }
    }
}