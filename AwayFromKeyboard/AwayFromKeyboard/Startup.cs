using Microsoft.Owin;
using Owin;
using System.Web.Hosting;
using System.Web.Services.Description;

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
