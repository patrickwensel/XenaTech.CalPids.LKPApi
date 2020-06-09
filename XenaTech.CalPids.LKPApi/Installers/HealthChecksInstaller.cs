using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XenaTech.CalPids.LKPApi.Data;
using XenaTech.CalPids.LKPApi.HealthChecks;

namespace XenaTech.CalPids.LKPApi.Installers
{
    public class HealthChecksInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddDbContextCheck<DataContext>()
                .AddCheck<RedisHealthCheck>("Redis");
        }
    }
}