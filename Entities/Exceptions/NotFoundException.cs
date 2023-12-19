using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class NotFoundException : Exception
    {

        public object NotFoundId { get; }
        public NotFoundException() : base()
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException(string message, object notFoundId) : base(message)
        {
            NotFoundId = notFoundId;
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
