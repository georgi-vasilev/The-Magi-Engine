using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(TheMagiEngine.Web.Areas.Identity.IdentityHostingStartup))]

namespace TheMagiEngine.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}