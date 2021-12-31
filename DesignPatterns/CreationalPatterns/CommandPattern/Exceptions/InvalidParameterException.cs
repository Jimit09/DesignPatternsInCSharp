using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.CommandPattern.Exceptions
{
    public class InvalidParameterException : Exception
    {
        public InvalidParameterException()
        {
        }

        public InvalidParameterException(string message) : base(message)
        {
        }

        public InvalidParameterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidParameterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
