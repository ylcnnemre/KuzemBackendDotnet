using Microsoft.EntityFrameworkCore;
using KuzemBackendDotnet.Domain;
using KuzemBackendDotnet.Persistence.Concretes;
using KuzemBackendDotnet.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace KuzemBackendDotnet.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/KuzemBackendDotnet.API"));
            configurationManager.AddJsonFile("appsettings.json");

            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<KuzemDbContext>(options => options.UseNpgsql( configurationManager.GetConnectionString("PostgreSql") ));
        }
    }
}
