using System;
using System.Runtime.Serialization;

namespace Namtar.Domain.Exceptions
{
    [Serializable]
    public class NamtarException: Exception
    {
        public NamtarException()
        {
        }

        public NamtarException(string message) : base(message)
        {
        }

        public NamtarException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NamtarException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
