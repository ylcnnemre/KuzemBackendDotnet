using KuzemBackendDotnet.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Domain.Entities
{
    public class Semester:BaseEntity
    {
        public Semester() { 
            this.Courses = new List<Course>();
        }
        public string Name { get; set; }
        public string Period { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
