using Namtar.Domain.Exceptions;
using System;
using System.Runtime.Serialization;

namespace Namtar.Repository.Exceptions
{
    [Serializable]
    public class RepositoryException : NamtarException
    {
        public RepositoryException()
        {
        }

        public RepositoryException(string message) : base(message)
        {
        }

        public RepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepositoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
