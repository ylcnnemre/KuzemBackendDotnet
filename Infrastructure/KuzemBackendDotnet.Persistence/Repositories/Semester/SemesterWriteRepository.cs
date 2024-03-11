using KuzemBackendDotnet.Application.Repositories;
using KuzemBackendDotnet.Domain.Entities;
using KuzemBackendDotnet.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Persistence.Repositories
{
    public class SemesterWriteRepository : WriteRepository<Semester>,ISemesterWriteRepository
    {
        public SemesterWriteRepository(KuzemDbContext context) : base(context)
        {
        }
    }
}
