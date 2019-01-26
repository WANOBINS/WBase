using System;

namespace WBase.Core.Exceptions
{
    public class WBaseInternalException : Exception
    {
        public WBaseInternalException()
        {
        }

        public WBaseInternalException(string message) : base(message)
        {
        }

        public WBaseInternalException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}