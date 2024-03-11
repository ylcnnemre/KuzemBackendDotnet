using KuzemBackendDotnet.Domain.Entities;
using KuzemBackendDotnet.Domain.Entities.Common;
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
        public DbSet<Course> Course { get; set; }

        public KuzemDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas=ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added=>data.Entity.CreatedDate=DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }

}
