using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using XenaTech.CalPids.LKPApi.Options;
using XenaTech.CalPids.LKPApi.Services;

namespace XenaTech.CalPids.LKPApi.Installers
{
    public class FacebookAuthInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var facebookAuthSettings = new FacebookAuthSettings();
            configuration.Bind(nameof(FacebookAuthSettings), facebookAuthSettings);
            services.AddSingleton(facebookAuthSettings);

            services.AddHttpClient();
            services.AddSingleton<IFacebookAuthService, FacebookAuthService>();
        }
    }
}