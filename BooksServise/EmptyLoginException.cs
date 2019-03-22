using System;
using System.Runtime.Serialization;

namespace BooksServise
{
    [Serializable]
    internal class EmptyLoginException : Exception
    {
        public EmptyLoginException()
        {
        }

        public EmptyLoginException(string message) : base(message)
        {
        }

        public EmptyLoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyLoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}