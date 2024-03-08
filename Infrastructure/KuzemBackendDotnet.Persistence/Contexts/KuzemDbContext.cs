using KuzemBackendDotnet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzemBackendDotnet.Persistence.Contexts
{
    public class KuzemDbContext : DbContext
    {
        public DbSet<Product> products { get; set; }

        public KuzemDbContext(DbContextOptions options) : base(options)
        {

        }
    }

}
