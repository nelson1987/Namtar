using System;
using System.Runtime.Serialization;

namespace Namtar.Domain.Exceptions
{
    [Serializable]
    public class DomainValidarionException : NamtarException
    {
        public DomainValidarionException()
        {
        }

        public DomainValidarionException(string message) : base(message)
        {
        }

        public DomainValidarionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DomainValidarionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}