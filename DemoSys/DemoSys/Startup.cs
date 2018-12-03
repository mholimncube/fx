using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoSys.Startup))]
namespace DemoSys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
