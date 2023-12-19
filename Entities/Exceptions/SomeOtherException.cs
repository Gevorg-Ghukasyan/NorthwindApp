using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class SomeOtherException : Exception
    {
        public SomeOtherException() : base("Something went wrong, please contact the administration.")
        {

        }

        public SomeOtherException(string message) : base(message)
        {

        }

        public SomeOtherException(string message, object notFoundId) : base(message)
        {
        }

        public SomeOtherException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public int SomeOtherStatusCode { get; } = 600;
    }
}
