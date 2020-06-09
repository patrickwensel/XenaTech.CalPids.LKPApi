using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XenaTech.CalPids.LKPApi.Data;
using XenaTech.CalPids.LKPApi.Services;

namespace XenaTech.CalPids.LKPApi.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ILastKnownPositionService, LastKnownPositionService>();
        }
    }
}