using System;

namespace SysSoftware.Model
{
    public class DbConnectionException : ApplicationException
    {
        public DbConnectionException() { }

        public DbConnectionException(string message) : base(message) { }
    }
}