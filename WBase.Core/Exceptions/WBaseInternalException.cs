using System;
using System.Runtime.Serialization;

namespace WBase.Core.Exceptions
{
    [Serializable]
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

        protected WBaseInternalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}