using Namtar.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Namtar.Application.Exceptions
{
    [Serializable]
    public class ApplicationServiceException : NamtarException
    {
        public ApplicationServiceException()
        {
        }

        public ApplicationServiceException(string message) : base(message)
        {
        }

        public ApplicationServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApplicationServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}