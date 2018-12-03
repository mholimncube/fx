using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AwayFromKeyboard.Startup))]
namespace AwayFromKeyboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
