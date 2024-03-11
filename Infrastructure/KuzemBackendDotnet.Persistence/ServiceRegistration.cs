using Microsoft.EntityFrameworkCore;
using KuzemBackendDotnet.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using KuzemBackendDotnet.Application.Repositories.Course;
using KuzemBackendDotnet.Persistence.Repositories;
using KuzemBackendDotnet.Application.Repositories;

namespace KuzemBackendDotnet.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/KuzemBackendDotnet.API"));
            configurationManager.AddJsonFile("appsettings.json");
            services.AddDbContext<KuzemDbContext>(options => options.UseNpgsql( configurationManager.GetConnectionString("PostgreSql") ));

            services.AddScoped<ICourseReadRepository,CourseReadRepository>();
            services.AddScoped<ICourseWriteRepository,CourseWriteRepository>(); 
            services.AddScoped<ISemesterReadRepository,SemesterReadRepository>();
            services.AddScoped<ISemesterWriteRepository,SemesterWriteRepository>();
        }
    }
}
