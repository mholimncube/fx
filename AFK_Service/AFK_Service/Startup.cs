using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AFK_Service.Startup))]
namespace AFK_Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
