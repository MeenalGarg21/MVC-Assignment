using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppDemoWithAuthtentication.Startup))]
namespace MVCAppDemoWithAuthtentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
