using KuzemBackendDotnet.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Domain.Entities
{
    public class Branch:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
