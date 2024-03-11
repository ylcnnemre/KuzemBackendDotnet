using KuzemBackendDotnet.Application.Repositories.Course;
using KuzemBackendDotnet.Domain.Entities;
using KuzemBackendDotnet.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Persistence.Repositories
{
    public class CourseWriteRepository : WriteRepository<Course>,ICourseWriteRepository
    {
        public CourseWriteRepository(KuzemDbContext context) : base(context)
        {
        }
    }
}
