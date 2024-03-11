using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Application.Exceptions
{
    public class ConflictException:Exception
    {
        public int StatusCode { get; }
        public ConflictException(string message, int statusCode) : base(message)
        {
            this.StatusCode = statusCode;
        }
    }

}
