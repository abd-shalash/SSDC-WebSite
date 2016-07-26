using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSDC_WebSite.Startup))]
namespace SSDC_WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
