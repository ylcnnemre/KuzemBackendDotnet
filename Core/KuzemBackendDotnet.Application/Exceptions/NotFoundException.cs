using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Application.Exceptions
{
    public class NotFoundException:Exception
    {
        public int StatusCode { get; }
        public NotFoundException(string message,int statusCode) : base(message)
        {
            this.StatusCode = statusCode;
        }
    }
}
