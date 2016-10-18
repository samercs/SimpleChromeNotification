using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleChromeNotification.Startup))]
namespace SimpleChromeNotification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
