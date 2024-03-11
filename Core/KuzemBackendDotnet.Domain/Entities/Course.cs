using KuzemBackendDotnet.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }

        public Semester? semester { get; set; }
    }
}
