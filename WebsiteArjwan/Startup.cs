using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteArjwan.Startup))]
namespace WebsiteArjwan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
